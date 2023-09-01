namespace YUpDown.Processing.Core.Processing
{
    public interface ITransferring
    {
        TransferringId TransferringId { get; }

        TransferringStatus Status { get; }

        void Run();
    }
}
