using YUpDown.Processing.Application.Dtos;

namespace YUpDown.Processing.Application.Services
{
    public class ProcessService : IProcessService
    {
        public Task StartProcess(StartProcessDto startProcess)
        {
            if (startProcess == null)
                throw new ArgumentNullException(nameof(startProcess));

            throw new NotImplementedException();
        }
    }
}
