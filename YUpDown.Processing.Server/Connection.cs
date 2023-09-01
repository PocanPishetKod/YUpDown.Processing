using System.Collections.Concurrent;
using LiteNetLib;
using YUpDown.Processing.Server.Interface;

namespace YUpDown.Processing.Server
{
    public class Connection : IConnection
    {
        private readonly NetPeer _peer;
        private readonly ConcurrentQueue<NetPacketReader> _receivedData;
        private readonly AutoResetEvent _receivedEvent;
        private readonly object _lock = new object();

        public ConnectionId Id => new ConnectionId(_peer.Id);

        public Connection(NetPeer peer)
        {
            _peer = peer ?? throw new ArgumentNullException(nameof(peer));
            _receivedData = new ConcurrentQueue<NetPacketReader>();
            _receivedEvent = new AutoResetEvent(false);
        }

        public void Disconnect()
        {
            _peer.Disconnect();
        }

        public Memory<byte> Receive()
        {
            Monitor.Enter(_lock);

            try
            {
                _receivedEvent.WaitOne();

                if (!_receivedData.TryDequeue(out var data))
                    throw new InvalidOperationException("Not received data.");

                _receivedEvent.Reset();

                return new Memory<byte>(data.RawData, data.UserDataOffset, data.UserDataSize);
            }
            finally 
            {
                Monitor.Exit(_lock);
            }
        }

        public void Send(Memory<byte> data)
        {
            _peer.Send(data.Span, DeliveryMethod.ReliableOrdered);
        }

        internal void OnReceived(NetPacketReader reader, byte channelNumber, DeliveryMethod deliveryMethod)
        {
            if (deliveryMethod != DeliveryMethod.ReliableOrdered)
                return;

            _receivedData.Enqueue(reader);
            _receivedEvent.Set();
        }
    }
}
