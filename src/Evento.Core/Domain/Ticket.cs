using System;

namespace Evento.Core.Domain
{
    public class Ticket
    {
        public Guid Id { get; private set; }
        public Event Event { get; private set; }
        public int Seating { get; private set; }
        public decimal Price { get; private set; }
        public Tool SomeProperty { get; set; }

        public Ticket(Event @event, int seating, decimal price)
        {
            Id = Guid.NewGuid();
            Event = @event;
            Seating = seating;
            Price = price;
            SomeProperty = new Tool(Guid.NewGuid(), "Default Tool", "Type A", 0); // Example initialization
        }
    }
}
