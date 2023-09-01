namespace YUpDown.Processing.Server.Interface
{
    public interface IConnection
    {
        ConnectionId Id { get; }

        Memory<byte> Receive();

        void Send(Memory<byte> data);

        void Disconnect();
    }
}
