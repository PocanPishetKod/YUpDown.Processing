using YUpDown.Processing.Application.Dtos;

namespace YUpDown.Processing.Application.Services
{
    public interface IProcessService
    {
        Task StartProcess(StartProcessDto startProcess);
    }
}
