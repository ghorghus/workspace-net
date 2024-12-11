using System;

namespace Evento.Core.Domain
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Role { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        public User(Guid id, string role, string name, string email, string password)
        {
            Id = id;
            Role = role;
            Name = name;
            Email = email;
            Password = password;
        }

        // Optional: Parameterless constructor if needed
        protected User()
        {
            Role = string.Empty;
            Name = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
        }
    }
}
