using CarsMvc.Models;
using CarsMvc.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.SessionState;

namespace CarsMvc.Services
{
    public class SecurityService : ISecurityService
    {
        private readonly IUserService _users;
        private readonly HttpSessionState _session;

        public SecurityService(IUserService users, HttpSessionState session =null)
        {
            _users = users;
            _session = session ?? HttpContext.Current.Session;
        }

        public bool Authenticate(string username, string password)
        {
            User user = _users.GetBy(username);
            
            if(user !=null){
                if(user.Password == Crypto.Hash(password)){
                    return true;
                }
            }
            return false;
        }
        public User CreateUser(SignupViewModel model,bool login= true)
        {
            var user = _users.Create(model.Username,model.Password,new UserProfile(){Email=model.Email},DateTime.Now);
            if (login)
            {
                Login(user.Username);
            }
            return user;
        }
        public bool DoesUserExits(string username) 
        {
            return _users.GetBy(username) != null; 
        }
        public User GetCurrentUser() 
        {
            return _users.GetBy(UserId);
        }
        public bool IsAuthenticate
        {
            get { return UserId > 0; }
        }
        public void Login(string username)
        {
            var user = _users.GetBy(username);
            _session["UserId"] = user.ID;
        }
        public void Logout() 
        {
            _session.Abandon(); 
        }
        public int UserId
        {
            get
            {
                return Convert.ToInt32(_session["UserId"]);
            }
            set
            {
                _session["UserId"] = value;
            }
        }
    }
}