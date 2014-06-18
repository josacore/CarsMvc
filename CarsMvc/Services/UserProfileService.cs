﻿using CarsMvc.Data;
using CarsMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsMvc.Services
{
    public class UserProfileService : IUserProfileService
    {
        private readonly IContext _context;
        private readonly IUserProfileRepository _profiles;

        public UserProfileService(IContext context)
        {
            _context = context;
            _profiles = context.Profiles;
        }

        public UserProfile GetBy(int id)
        {
            return _profiles.Find(p => p.ID == id);
        }
    }
}