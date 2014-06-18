using CarsMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarsMvc.Data
{
    public class UserProfileRepository : Repository<UserProfile>, IUserProfileRepository
    {
        public UserProfileRepository(DbContext context,bool sharedContext) : base(context,sharedContext)
        {}
    }
}