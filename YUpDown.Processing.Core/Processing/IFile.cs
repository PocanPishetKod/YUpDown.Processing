namespace YUpDown.Processing.Core.Processing
{
    public interface IFile : IDisposable
    {
        string Path { get; }

        void Open();

        Task Write(Memory<byte> bytes);

        Task Read(Memory<byte> destination, long startIndex);

        Task Flush();
    }
}
