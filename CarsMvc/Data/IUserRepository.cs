using CarsMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsMvc.Data
{
    public interface IUserRepository : IRepository<User>
    {
        IQueryable<User> All(bool includeProfile);
        User GetBy(string username, bool includeProfile = false);
        User GetBy(int id, bool includeProfile = false);
    }
}