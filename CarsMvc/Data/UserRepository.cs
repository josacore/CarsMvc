using CarsMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarsMvc.Data
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DbContext context,bool sharedContext) : base(context,sharedContext)
        {}

        public IQueryable<User> All(bool includeProfile)
        {
            return includeProfile ? DbSet.Include(u => u.Profile).AsQueryable() : All();
        }

        public User GetBy(string username, bool includeProfile = false)
        {
            if (includeProfile) {
                DbSet.Include(u => u.Profile);
            }
            DbSet.AsQueryable();
            return DbSet.SingleOrDefault(u => u.Username == username);
        }

        public User GetBy(int id, bool includeProfile = false)
        {
            if (includeProfile)
            {
                DbSet.Include(u => u.Profile);
            }
            DbSet.AsQueryable();
            return DbSet.SingleOrDefault(u => u.ID == id);
        }
    }
}