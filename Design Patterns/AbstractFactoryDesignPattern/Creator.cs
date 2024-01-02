namespace Design_Patterns.AbstractFactoryDesignPattern
{
    public class Creator
    {
        DatabaseFactory _databaseFactory;
        Connection _connection;
        Command _command;

        public Creator(DatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
            _connection = _databaseFactory.CreateConnection();
            _command = _databaseFactory.CreateCommand();
        }

        public void Start() 
        {
            if (_connection.State == "Open")
            {
                _connection.Connect();
                _command.Execute("test");
                _connection.Disconnect();
            }
        }        
    }
}
