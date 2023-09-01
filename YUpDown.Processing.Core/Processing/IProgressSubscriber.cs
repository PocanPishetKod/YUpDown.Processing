namespace YUpDown.Processing.Core.Processing
{
    public interface IProgressSubscriber
    {
        void OnProgress(ProgressValue value);
    }
}
