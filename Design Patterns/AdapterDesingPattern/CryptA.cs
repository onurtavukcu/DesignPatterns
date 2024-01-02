namespace Design_Patterns.AdapterDesingPattern
{
    public class CryptA : IAdapterDesignPattern
    {
        public string Decryp(string text)
        {
            return text.ToUpper();
        }

        public string Encryp(string text)
        {
            return text.ToUpper();
        }
    }
}
