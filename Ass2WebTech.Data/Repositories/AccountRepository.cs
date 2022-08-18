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

        public async Task<List<Account>> GetAccountsByCustomerId(int id)
        {
            var result = await _context.Accounts
                .Where(x => x.CustomerID.Equals(id))
                .ToListAsync();

            return result;

        }

        public async Task<Account> AddBalance(int id, double amount)
        {
            
            var entity = await _context.Accounts
                .FirstOrDefaultAsync(x => x.CustomerID == id);
            
            Console.WriteLine(entity.Balance);
            
            entity.Balance = entity.Balance + amount;

            _context.Accounts.Update(entity);
            
            return entity;
        }

         public async Task<Account> RemoveBalance(int id, double amount)
        {
            
            var entity = await _context.Accounts
                .FirstOrDefaultAsync(x => x.CustomerID == id);
            
            Console.WriteLine(entity.Balance);

            var a = entity.Balance;
            var b = amount;
            entity.Balance = a + b;

            _context.Accounts.Update(entity);
            
            return entity;
        }
    }   
}