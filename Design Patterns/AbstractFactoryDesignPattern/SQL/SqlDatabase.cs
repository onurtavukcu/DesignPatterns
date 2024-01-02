namespace Design_Patterns.AbstractFactoryDesignPattern.SQL
{
    public class SqlDatabase : DatabaseFactory
    {
        public override Command CreateCommand()
        {
            return new SqlCommand();
        }

        public override Connection CreateConnection()
        {
            return new SqlConnection();
        }
    }
}
