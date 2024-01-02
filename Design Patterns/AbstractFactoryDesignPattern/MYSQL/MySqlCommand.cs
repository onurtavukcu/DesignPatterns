namespace Design_Patterns.AbstractFactoryDesignPattern.MYSQL
{
    public class MySqlCommand : Command
    {
        public override void Execute(string query)
        {
            Console.WriteLine($"{query} MySql Query çalıştırılıyor.");
        }
    }
}
