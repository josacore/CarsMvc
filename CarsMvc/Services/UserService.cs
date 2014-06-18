using CarsMvc.Data;
using CarsMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsMvc.Services
{
    public class UserService : IUserService
    {
        private readonly IContext _context;
        private readonly IUserRepository _users;

        public UserService(IContext context)
        {
            _context = context;
            _users = context.Users;
        }

        public IEnumerable<Models.User> All(bool includeProfile)
        {
            return _users.All(includeProfile).ToArray();
        }

        public Models.User GetBy(string username)
        {
            return _users.GetBy(username);
        }

        public Models.User GetBy(int id)
        {
            return _users.GetBy(id);
        }

        public Models.User Create(string username, string password, Models.UserProfile profile, DateTime? created = null)
        {
            var user = new User()
            {
                Username = username,
                Password = password,
                DateCreated = created ?? DateTime.Now,
                Profile = profile
            };
            _users.Create(user);
            _context.SaveChanges();
            return user;
        }
    }
}