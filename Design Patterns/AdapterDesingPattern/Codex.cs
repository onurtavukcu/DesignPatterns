namespace Design_Patterns.AdapterDesingPattern
{
    public class Codex
    {
        public string CodexString(string codextText)
        {
            return codextText.ToUpper();
        }

        public string StringCodex(string codextText)
        {
            return codextText.ToUpper();
        }
    }
}
