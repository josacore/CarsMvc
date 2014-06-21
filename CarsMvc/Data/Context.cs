using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarsMvc.Data
{
    public class Context : IContext
    {
        private readonly DbContext _db;

        public Context(DbContext context = null, 
                    IUserRepository users = null,
                    IUserProfileRepository profiles = null,
                    IModelRepository models = null,
                    IBrandRepository brands = null,
                    ITypeRepository types =null)
        {
            _db = context ?? new CarDatabase();
            Users = users ?? new UserRepository(_db,true);
            Profiles = profiles ?? new UserProfileRepository(_db, true);
            Models = models ?? new ModelRepository(_db, true);
            Brands = brands ?? new BrandRepository(_db, true);
            Types = types ?? new TypeRepository(_db, true);
        }
        public IBrandRepository Brands { get; private set; }
        public IModelRepository Models { get; private set; }
        public IUserRepository Users { get; private set; }
        public IUserProfileRepository Profiles{ get; private set; }
        public ITypeRepository Types { get; private set; }

        public int SaveChanges()
        {
            return _db.SaveChanges();
        }

        public void Dispose()
        {
            if(_db != null)
            {
                try
                {
                    _db.Dispose();
                }catch{}
            }
        }
    }
}