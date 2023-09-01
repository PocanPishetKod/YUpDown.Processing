namespace YUpDown.Processing.Core.Processing
{
    public class UploadTransferring : ITransferring
    {
        private readonly ICompleteSubscriber _completeSubscriber;
        private readonly IReadOnlyList<IFile> _fIleDescriptions;

        public TransferringId TransferringId { get; }

        public TransferringStatus Status { get; private set; }

        public UploadTransferring(
            TransferringId transferringId,
            IReadOnlyList<IFile> fIleDescriptions,
            ICompleteSubscriber subscriber)
        {
            _fIleDescriptions = fIleDescriptions ?? throw new ArgumentNullException(nameof(fIleDescriptions));
            _completeSubscriber = subscriber ?? throw new ArgumentNullException(nameof(subscriber));
            TransferringId = transferringId;
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
