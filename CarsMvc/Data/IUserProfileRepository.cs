using CarsMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsMvc.Data
{
    public interface IUserProfileRepository : IRepository<UserProfile>
    {}
}