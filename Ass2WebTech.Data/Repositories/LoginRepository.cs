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

        public async Task<Login> CreateLogin(Login login)
        {

            await _context.Logins
                .AddAsync(login);

            return login;
        }

        public async Task<Login?> GetLoginById(string id)
        {
            return await _context.Logins
                .SingleOrDefaultAsync(l =>l.LoginID == id);
        }

        public Task<Login> UpdateLogin(string id)
        {
            throw new NotImplementedException();
        }
    }
}