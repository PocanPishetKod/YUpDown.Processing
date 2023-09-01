namespace YUpDown.Processing.Server.Interface
{
    public struct ConnectionId
    {
        private readonly int _id;

        public ConnectionId(int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id));

            _id = id;
        }
    }
}
