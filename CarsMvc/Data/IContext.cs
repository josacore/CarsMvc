using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsMvc.Data
{
    public interface IContext :IDisposable
    {
        IUserRepository Users { get; }
        IUserProfileRepository Profiles { get; }
        int SaveChanges();
    }
}