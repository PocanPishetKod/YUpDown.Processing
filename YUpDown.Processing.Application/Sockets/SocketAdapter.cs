using YHome.StreamingData.Streams;

namespace YUpDown.Processing.Application.Sockets
{
    public class SocketAdapter : IConnection, ISocket
    {
        private readonly Server.Interface.IConnection _connection;

        public SocketAdapter(Server.Interface.IConnection connection)
        {
            _connection = connection;
        }

        public event Action<ReadOnlyMemory<byte>>? Received;

        public Task<int> Receive(Memory<byte> buffer)
        {
            var receivedData = _connection.Receive();

            receivedData.CopyTo(buffer);

            return Task.FromResult(receivedData.Length);
        }

        public Task Send(Memory<byte> data)
        {
            _connection.Send(data);
            return Task.CompletedTask;
        }
    }
}
