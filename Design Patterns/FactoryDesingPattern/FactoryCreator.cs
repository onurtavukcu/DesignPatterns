namespace Design_Patterns.FactoryDesingPattern
{
    public class FactoryCreator
    {
        public Oyun FactoryMethot(Oyunlar oyunTipi)
        {
            Oyun oyun = null;

            switch (oyunTipi) 
            {
                case Oyunlar.Atari:
                    oyun = new Atari();
                    break;
                case Oyunlar.PC:
                    oyun = new PC();
                    break;
            }
            return oyun;
        }
    }
}
