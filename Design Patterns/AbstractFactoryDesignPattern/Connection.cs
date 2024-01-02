namespace Design_Patterns.AbstractFactoryDesignPattern
{
    public abstract class Connection
    {
        public abstract bool Connect();
        public abstract bool Disconnect();
        public abstract string State { get; }
    }
}
