using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ass2WebTech.Models;

namespace Ass2WebTech.Core.Interfaces
{
    public interface IAccountRepository
    {
        Task<Account?> GetAccountById(int id);

        Task<List<Account>> GetAccountsByCustomerId(int id);

        Task<Account> CreateAccount(Account account);

        Task<Account> AddBalance(int id, double amount);
        Task<Account> RemoveBalance(int id, double amount);
    
    }
}