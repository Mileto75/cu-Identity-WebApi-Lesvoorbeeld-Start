using cu.ApiBAsics.Lesvoorbeeld.Avond.Core.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cu.ApiBAsics.Lesvoorbeeld.Avond.Core.Interfaces.Services
{
    public interface IUserService
    {
        Task<AuthenticateResultModel> Login(string username, string password);
        Task Logout();
        Task<AuthenticateResultModel> Register(string firstname, string lastname, string username, string password);
    }
}
