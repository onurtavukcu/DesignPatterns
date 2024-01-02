namespace Design_Patterns.AdapterDesingPattern
{
    public class AdapterOperations
    {
        public string Operations()
        {
            CryptA cryptA = new CryptA();

            var cryptnormal = cryptA.Encryp("normalencrypt");
            var encryptnormal = cryptA.Decryp("normaldecrypt");

            Codex codex = new Codex();

            var codexed = new CodexAdapter(codex);

            var codextencrtypt = codexed.Encryp("codexedencrypt");
            var codextendecrtypt = codexed.Decryp("codexeddecrypt");

            return cryptnormal + encryptnormal + codextencrtypt + codextendecrtypt;
        }
    }
}
