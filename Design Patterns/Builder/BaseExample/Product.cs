namespace Builder.BaseExample
{
    internal class Product
    {
        private List<object> _parts = new();

        public void Add(string part)
            => _parts.Add(part);

        public string ListParts()
        {
            string str = string.Join(',', _parts);
            return $"Product parts: {str}\n";
        }
    }
}
