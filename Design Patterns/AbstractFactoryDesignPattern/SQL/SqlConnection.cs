namespace Design_Patterns.AbstractFactoryDesignPattern.SQL
{
    public class SqlConnection : Connection
    {
        public override string State => "Open";

        public override bool Connect()
        {
            Console.WriteLine("SqlConnection Connecting");
            return true;
        }

        public override bool Disconnect()
        {
            Console.WriteLine("SqlConnection Disconnecting");
            return true;
        }
    }
}
