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

        Task<IEnumerable<Account>> GetAccountsByCustomerId(int id);

        Task<Account> CreateAccount(Account account);

        Task<Account> UpdateBalance(int id, double amount);
    
    }
}