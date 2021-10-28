namespace CrAgPeliculas.App.Client.Helpers
{
    public struct MultiSelectorModel
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public MultiSelectorModel(string Key, string Value) : this()
        {
            this.Key = Key;
            this.Value = Value;
        }
    }
}