using LiteNetLib;
using YUpDown.Processing.Server.Interface;

namespace YUpDown.Processing.Server
{
    public class UdpServer : IServer
    {
        private readonly NetManager _netManager;
        private readonly ServerSettings _settings;

        private readonly ConnectionStore _connectionStore;

        public bool IsListening => _netManager.IsRunning;

        public UdpServer(ServerSettings serverSettings, IServerListener serverListener)
        {
            _settings = serverSettings ?? throw new ArgumentNullException(nameof(serverSettings));
            _connectionStore = new ConnectionStore();
            _netManager = new NetManager(new NetListener(serverListener ?? throw new ArgumentNullException(nameof(serverListener)), _connectionStore));
        }

        public void Run()
        {
            if (IsListening)
                throw new InvalidOperationException("Server already started");

            if (!_netManager.Start(_settings.ListenOnV4, _settings.ListenOnV6, _settings.Port))
                throw new InvalidOperationException("Error starting server");
        }

        public void Stop()
        {
            _netManager.Stop(true);
        }
    }
}
