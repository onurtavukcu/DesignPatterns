namespace Design_Patterns.AbstractFactoryDesignPattern
{
    public abstract class DatabaseFactory
    {
        public abstract Connection CreateConnection();
        public abstract Command CreateCommand();
    }
}
