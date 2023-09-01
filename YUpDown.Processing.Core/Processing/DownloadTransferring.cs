namespace YUpDown.Processing.Core.Processing
{
    public class DownloadTransferring : ITransferring
    {
        private readonly IReadOnlyList<IFile> _files;
        private readonly ITransferringChannel _channel;

        private Task? _process;

        public TransferringId TransferringId { get; }

        public TransferringStatus Status { get; private set; }

        public DownloadTransferring(
            TransferringId transferringId,
            IReadOnlyList<IFile> files,
            ITransferringChannel channel)
        {
            _files = files ?? throw new ArgumentNullException(nameof(files));
            TransferringId = transferringId;
            _channel = channel ?? throw new ArgumentNullException(nameof(channel));
            Status = TransferringStatus.Ready;
        }

        public void Run()
        {
            if (Status != TransferringStatus.Ready)
                throw new InvalidOperationException("Invalid transferring status for run.");

            Status = TransferringStatus.Transferring;
            _process = RunInternal();
        }

        private async Task RunInternal()
        {

        }
    }
}
