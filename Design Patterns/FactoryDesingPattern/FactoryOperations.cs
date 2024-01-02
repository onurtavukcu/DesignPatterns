namespace Design_Patterns.FactoryDesingPattern
{
    public class FactoryOperations
    {
        public string Operations()
        {
            FactoryCreator creator = new FactoryCreator();

            Oyun atariOyunu = creator.FactoryMethot(Oyunlar.Atari);
            Oyun pcOyunu = creator.FactoryMethot(Oyunlar.PC);

            var resultAtari = atariOyunu.Platform();
            var resultPC = pcOyunu.Platform();

            return resultPC + resultAtari;
        }
    }
}
