namespace Design_Patterns.AbstractFactoryDesignPattern.SQL
{
    public class SqlCommand : Command
    {
        public override void Execute(string query)
        {
            Console.WriteLine($"{query} Sql Query çalıştırılıyor.");
        }
    }
}
