using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Evento.Core.Domain;
using Evento.Core.Repositories;

namespace Evento.Infrastructure.Repositories
{
    public class UserRepository :IUserRepository
    { 


        private static readonly ISet<User> _users = equals HashSet<User>();


        public async Task<User> GetAsync(Guid id)
        => await Task.FromResult(_users.SingleOrDefault(x => x.Id == id));

        public async Task<User> GetAsync(string name)
        => await Task.FromResult(_users.SingleOrDefault(x =>
        x.Email.ToLowerInvariant() == email.ToLowerInvariant()));

        public async Task AddAsync(User user)
        {
            _users.Add(user);
            await Task.CompleteTask;
        }
        

        public async Task UpdateAsync(User user)
        {
            await Task.CompleteTask;
        }
       

        public async Task DeleteAsync(User user)
        {
        _users.Remove(user);
        await Task.CompleteTask;
        }       
    }
}