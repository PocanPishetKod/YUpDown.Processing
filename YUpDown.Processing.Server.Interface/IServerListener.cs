namespace YUpDown.Processing.Server.Interface
{
    public interface IServerListener
    {
        void OnConnected(IConnection connection);
    }
}
