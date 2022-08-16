using Ass2WebTech.Core.Interfaces;
using Ass2WebTech.Models;
using Microsoft.EntityFrameworkCore;

namespace Ass2WebTech.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankContext _context;

        public AccountRepository(BankContext context) 
        { 
            _context = context;
        }

        public async Task<Account?> GetAccountById(int id)
        {  
            
            return await _context.Accounts
                .SingleOrDefaultAsync(x => x.CustomerID == id);

        }

        public async Task<Account> CreateAccount(Account account)
        {
            await _context.Accounts.AddAsync(account);
            return account;

        }

        public async Task<IEnumerable<Account>> GetAccountsByCustomerId(int id)
        {
            
            return await _context.Accounts
                .Where(x => x.CustomerID == id)
                .ToListAsync();
        }

    }
}