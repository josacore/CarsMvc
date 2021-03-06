﻿using CarsMvc.Models;
using CarsMvc.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsMvc.Services
{
    public interface IUserProfileService
    {
        UserProfile GetBy(int id);
        void Update(EditProfileViewModel model);
    }
}