using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ass2WebTech.Models;

namespace Ass2WebTech.Core.Interfaces
{
    public interface ILoginRepository
    {
        Task<Login?> GetLoginById(string id);
        Task<Login> UpdateLogin(string id);
        Task<Login> CreateLogin(Login login);
    }
}