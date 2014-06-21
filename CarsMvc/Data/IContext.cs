using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsMvc.Data
{
    public interface IContext :IDisposable
    {
        IBrandRepository Brands { get; }
        ICarRepository Cars { get; }
        IImageCarRepository ImageCars { get; }
        IModelRepository Models { get; }
        IUserRepository Users { get; }
        ITypeRepository Types { get; }
        IUserProfileRepository Profiles { get; }
        int SaveChanges();
    }
}