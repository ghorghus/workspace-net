namespace Evento.Core.Domain
{
    public class Tool
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }

        public Tool(Guid id, string name, string type, decimal price)
        {
            Id = id;
            Name = name;
            Type = type;
            Price = price;
        }
    }
}
