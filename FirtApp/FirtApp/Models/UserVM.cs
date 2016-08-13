using BussinessObject.Model;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirtApp.Models
{
    public class UserVM
    {
        public String Build(User user)
        {
            if (user.Name == null && user.Name.Length < 3)
            {
                return "User Name is not Valid";
            }
            else
            {
                UserRepos userRepos = new UserRepos();
                userRepos.AddUser(user);
                return "User successfully added";
            }   
        }
    }
}