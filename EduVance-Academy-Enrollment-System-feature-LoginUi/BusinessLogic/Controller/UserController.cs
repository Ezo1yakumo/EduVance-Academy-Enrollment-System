using System;
using EduVance.BusinessLogic.Repository;
using EduVance.Models;

namespace EduVance.BusinessLogic.Controller
{
    public sealed class UserController
    {
        private readonly UserRepository repository;

        public UserController(string connectionString)
        {
            repository = new UserRepository(connectionString);
        }

        public AuthenticatedUser Login(string username, string password)
        {
            if (String.IsNullOrWhiteSpace(username) || String.IsNullOrWhiteSpace(password))
                return null;

            return repository.Authenticate(username.Trim(), password);
        }
    }
}
