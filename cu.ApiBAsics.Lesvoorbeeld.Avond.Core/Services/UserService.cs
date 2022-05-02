using cu.ApiBAsics.Lesvoorbeeld.Avond.Core.Entities;
using cu.ApiBAsics.Lesvoorbeeld.Avond.Core.Interfaces.Services;
using cu.ApiBAsics.Lesvoorbeeld.Avond.Core.Services.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cu.ApiBAsics.Lesvoorbeeld.Avond.Core.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public UserService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<AuthenticateResultModel> Login(string username, string password)
        {
            //check if user exists
            var user = await _userManager.FindByNameAsync(username);
            if (user == null)
            {
                return new AuthenticateResultModel {
                Messages = new List<string> { "Login failed!"}
                };
            }
            //user exists => sign in
            var result = await _signInManager.PasswordSignInAsync(
                user,password,false,false);
            if(!result.Succeeded)
            {
                return new AuthenticateResultModel
                {
                    Messages = new List<string> { "Login failed!" }
                };
            }
            //user exists and is logged in
            return new AuthenticateResultModel
            {
                Success = true,
                Messages = new List<string> { "Logged in!" }
            };
        }

        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<AuthenticateResultModel> Register(string firstname, string lastname, string username, string password)
        {
            //check is username exists
            var user = await _userManager.FindByNameAsync(username);
            if(user != null)
            {
                return new AuthenticateResultModel 
                {
                    Messages = new List<string> { "Registration failed"}
                };
            }
            //create a user
            var newUser = new ApplicationUser
            {
                UserName = username,
                Email = username,
                Firstname = firstname,
                Lastname = lastname,
            };
            //put in database 
            var result = await _userManager.CreateAsync(newUser,password);
            if (result.Succeeded)
            {
                return new AuthenticateResultModel
                {
                    Success = true,
                    Messages = new List<string> { "User registered!" }
                };
            }
            return new AuthenticateResultModel
            {
                Messages = new List<string> { "Registration failed" }
            };
        }
    }
}
