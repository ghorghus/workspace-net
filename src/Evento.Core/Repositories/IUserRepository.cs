namespace Evento.Core.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetAsync(Guid id);

        Task<User> GetAsync(string email);

        Task<IEnumerable<Event>> BrowseAsync(string name = "");

        Task AddSync(User user);

        Task UpdateAsync(User user);

        Task DeleteAsync(user user);
    }
}