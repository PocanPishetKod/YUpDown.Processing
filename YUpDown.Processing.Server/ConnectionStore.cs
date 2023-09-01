namespace YUpDown.Processing.Server
{
    internal class ConnectionStore
    {
        private readonly List<Connection> _connections;

        public ConnectionStore()
        {
            _connections = new List<Connection>();
        }

        public void AddConnection(Connection connection)
        {
            _connections.Add(connection);
        }
    }
}
