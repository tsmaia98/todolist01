using Entities;
using Microsoft.EntityFrameworkCore;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListAPI.Services
{
    public class UserService
    {
        private UserRepository repository;

        public UserService(UserRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            var User = await repository.GetAllAsync();
            return User;
        }

        public async Task<User> GetOneUserByIdAsync(int id)
        {
            var User = await repository.GetOneUserByIdAsync(id);
            return User;
        }
    }
}