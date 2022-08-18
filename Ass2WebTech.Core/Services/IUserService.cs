using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ass2WebTech.Models;

namespace Ass2WebTech.Core.Services
{
    public interface IUserService
    {

        //TODO
        Task Preload();
        Task<Login> Login(string user, string pass);
        Task<IEnumerable<Account>> DisplayAccounts(int accountId);
        Task<Login> Logout();
        Task<Transaction> Deposit(int accountNumber, double amount, string comment);
        Task<Account> Withdraw(int accountId, double amount);
        Task<Transaction> Transfer(Transaction transaction);
        Task<IEnumerable<Account>> MyStatements(int customerId);
        Task<Customer> MyProfile(int customerId);
        Task<IEnumerable<BillPay>> BillPay();


        
    }
}