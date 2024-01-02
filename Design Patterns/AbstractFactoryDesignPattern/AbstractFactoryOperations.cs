using Design_Patterns.AbstractFactoryDesignPattern.MYSQL;
using Design_Patterns.AbstractFactoryDesignPattern.SQL;

namespace Design_Patterns.AbstractFactoryDesignPattern
{
    public class AbstractFactoryOperations
    {
        public void Operations()
        {
            Creator create = new Creator(new SqlDatabase());

            create.Start();

            Console.WriteLine("********");

            create = new Creator(new MsSqlDatabase());

            create.Start();
        }
        
    }
}
