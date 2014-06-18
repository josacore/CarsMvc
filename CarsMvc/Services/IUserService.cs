using CarsMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsMvc.Services
{
    public interface IUserService
    {
        IEnumerable<User> All(bool includeProfile);
        //User GetAllFor(string username);
        //User GetAllFor(int id);
        User GetBy(string username);
        User GetBy(int id);
        User Create(string username, string password, UserProfile profile, DateTime? created = null);
    }
}