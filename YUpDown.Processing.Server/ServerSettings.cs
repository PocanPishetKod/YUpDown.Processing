using System.Net;

namespace YUpDown.Processing.Server
{
    public class ServerSettings
    {
        public IPAddress ListenOnV4 { get; }

        public IPAddress ListenOnV6 { get; }

        public int Port { get; }

        public ServerSettings(IPAddress listenOnV4, IPAddress listenOnV6, int port)
        {
            ListenOnV4 = listenOnV4 ?? throw new ArgumentNullException(nameof(listenOnV4));
            ListenOnV6 = listenOnV6 ?? throw new ArgumentNullException(nameof(listenOnV6));
            Port = port;
        }
    }
}
