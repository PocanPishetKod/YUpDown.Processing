namespace YUpDown.Processing.Core.Processing
{
    public readonly ref struct ProgressValue
    {
        public readonly int SendedFilesCount;
        public readonly long CurrentFileSendedBytes;

        public ProgressValue(int sendedFilesCount, long currentFileSendedBytes)
        {
            SendedFilesCount = sendedFilesCount;
            CurrentFileSendedBytes = currentFileSendedBytes;
        }
    }
}
