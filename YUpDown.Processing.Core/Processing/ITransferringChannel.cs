namespace YUpDown.Processing.Core.Processing
{
    public interface ITransferringChannel
    {
        event Action<ReadOnlyMemory<byte>> Received;

        event Action Closed;

        event Action Disconnected;

        Task Send(ReadOnlyMemory<byte> data);

        Task Close();
    }
}
