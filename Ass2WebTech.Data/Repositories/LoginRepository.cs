using Ass2WebTech.Core.Interfaces;
using Ass2WebTech.Models;
using Microsoft.EntityFrameworkCore;

namespace Ass2WebTech.Data.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly BankContext _context;

        public LoginRepository(BankContext context) 
        { 
            _context = context;
        }

        public Task<Login> CreateLogin()
        {
            throw new NotImplementedException();
        }

        public Task<Login> GetLoginById()
        {
            throw new NotImplementedException();
        }

        public Task<Login> UpdateLogin()
        {
            throw new NotImplementedException();
        }
    }
}