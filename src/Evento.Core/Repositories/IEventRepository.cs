namespace Evento.Core.Repositories
{
    public interface IEventRepository
    {
        Task<Event> GetAsync(Guid id);

        Task<Event> GetAsync(string name);

        Task<IEnumerable<Event>> BrowseAsync(string name = "");

        Task AddSync(Evemt @evemt);

        Task UpdateAsync(Event @event);

        Task DeleteAsync (Evento evento);
    }
}