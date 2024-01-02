namespace Design_Patterns.AdapterDesingPattern
{
    public class CodexAdapter : IAdapterDesignPattern
    {
        private Codex _codex;

        public CodexAdapter(Codex codex)
        {
            _codex = codex;
        }
        public string Decryp(string text)
        {
            return _codex.StringCodex(text);
        }

        public string Encryp(string text)
        {
            return _codex.CodexString(text);
        }
    }
}
