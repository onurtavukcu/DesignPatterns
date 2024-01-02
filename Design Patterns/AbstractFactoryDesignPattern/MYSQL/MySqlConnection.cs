namespace Design_Patterns.AbstractFactoryDesignPattern.MYSQL
{
    public class MySqlConnection : Connection
    {
        public override string State => "Open";

        public override bool Connect()
        {
            Console.WriteLine("MYSqlConnection Connecting");
            return true;
        }

        public override bool Disconnect()
        {
            Console.WriteLine("MySqlConnection Disconnecting");
            return true;
        }
    }
}
