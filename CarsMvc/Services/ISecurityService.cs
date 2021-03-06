﻿using CarsMvc.Models;
using CarsMvc.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsMvc.Services
{
    public interface ISecurityService
    {
        bool Authenticate(string username, string password);
        User CreateUser(SignupViewModel model,bool login= true);
        bool DoesUserExits(string username);
        User GetCurrentUser();
        bool IsAuthenticate { get; }
        void Login(string username);
        void Logout();
        int UserId { get; set; }
    }
}