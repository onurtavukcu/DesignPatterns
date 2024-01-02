namespace Design_Patterns.AbstractFactoryDesignPattern.MYSQL
{
    public class MsSqlDatabase : DatabaseFactory
    {
        public override Command CreateCommand()
        {
            return new MySqlCommand();
        }

        public override Connection CreateConnection()
        {
            return new MySqlConnection();
        }
    }
}

