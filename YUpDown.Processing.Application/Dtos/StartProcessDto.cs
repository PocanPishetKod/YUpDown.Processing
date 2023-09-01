using YUpDown.Processing.Server.Interface;

namespace YUpDown.Processing.Application.Dtos
{
    public class StartProcessDto
    {
        public IConnection Connection { get; }

        public StartProcessDto(IConnection connection)
        {
            Connection = connection ?? throw new ArgumentNullException(nameof(connection));
        }
    }
}
