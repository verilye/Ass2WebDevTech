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
        Task<Transaction> Deposit();
        Task<Transaction> Transfer();
        Task<IEnumerable<Account>> MyStatements();
        Task<Customer> MyProfile();
        Task<IEnumerable<BillPay>> BillPay();


        
    }
}