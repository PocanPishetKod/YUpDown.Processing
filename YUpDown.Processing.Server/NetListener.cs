using System.Net;
using System.Net.Sockets;
using LiteNetLib;
using YUpDown.Processing.Server.Interface;

namespace YUpDown.Processing.Server
{
    internal class NetListener : INetEventListener
    {
        private readonly IServerListener _serverListener;
        private readonly ConnectionStore _connectionStore;

        public NetListener(IServerListener serverListener, ConnectionStore connectionStore)
        {
            _serverListener = serverListener;
            _connectionStore = connectionStore;
        }

        public void OnConnectionRequest(ConnectionRequest request)
        {
            throw new NotImplementedException();
        }

        public void OnNetworkError(IPEndPoint endPoint, SocketError socketError)
        {
            throw new NotImplementedException();
        }

        public void OnNetworkLatencyUpdate(NetPeer peer, int latency)
        {
            throw new NotImplementedException();
        }

        public void OnNetworkReceive(NetPeer peer, NetPacketReader reader, byte channelNumber, DeliveryMethod deliveryMethod)
        {
            throw new NotImplementedException();
        }

        public void OnNetworkReceiveUnconnected(IPEndPoint remoteEndPoint, NetPacketReader reader, UnconnectedMessageType messageType)
        {
            throw new NotImplementedException();
        }

        public void OnPeerConnected(NetPeer peer)
        {
            var connection = new Connection(peer);
            
            _connectionStore.AddConnection(connection);
            _serverListener.OnConnected(connection);
        }

        public void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo)
        {
            throw new NotImplementedException();
        }
    }
}
