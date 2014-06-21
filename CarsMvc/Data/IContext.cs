using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsMvc.Data
{
    public interface IContext :IDisposable
    {
        IBrandRepository Brands { get; }
        IModelRepository Models { get; }
        IUserRepository Users { get; }
        ITypeRepository Types { get; }
        IUserProfileRepository Profiles { get; }
        int SaveChanges();
    }
}