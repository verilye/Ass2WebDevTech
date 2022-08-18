using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ass2WebTech.Core;
using Ass2WebTech.Core.Services;
using Ass2WebTech.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SimpleHashing;

namespace Ass2WebTech.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        static readonly HttpClient client = new HttpClient();
        
        public UserService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task Preload()
        {

            if(_unitOfWork.Customers.CheckForCustomers())
            { 
                Console.WriteLine("Skipped preloading data");
                return;
            }
            
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://coreteaching01.csit.rmit.edu.au/~e103884/wdt/services/customers/");
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                var customers = JsonConvert.DeserializeObject<List<Customer>>(responseBody);

                foreach (var customer in customers.ToList())
                {
                    
        
                    Customer cust = new Customer(customer.City, customer.Name, customer.CustomerID, 
                        customer.Address);
                    await  _unitOfWork.Customers.CreateCustomer(cust);
                    // await _unitOfWork.CommitAsync();

                    Login log = new Login(customer.Login.LoginID, customer.CustomerID,customer.Login.PasswordHash);

                    await _unitOfWork.Logins.CreateLogin(log);
                    // await _unitOfWork.CommitAsync();

                    
                    foreach (var account in customer.Accounts.ToList())
                    {
                
                        await _unitOfWork.Accounts.CreateAccount(account);
                        // await _unitOfWork.CommitAsync();

                        foreach (var transaction in account.Transactions.ToList())
                        {
                            // Transaction trans = new Transaction( TransactionType.Deposit, transaction.AccountNumber, transaction.Amount
                            //     , transaction.TransactionTimeUtc,  transaction.DestinationAccountNumber);
                            await _unitOfWork.Transactions.CreateTransaction(transaction);
                            // await _unitOfWork.CommitAsync();
                        }
                    }

                }

                await _unitOfWork.CommitAsync();
                Console.WriteLine("DONESKI");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);

            }
            
            

            return;
        }

        public async Task<Login> Login(string user, string pass)
        {

            var result = await _unitOfWork.Logins.GetLoginById(user);
                        await _unitOfWork.CommitAsync();

            if(result == null)
            {
                return null;
            }

            //Use PBKDF2.Verify(passwordHash, password) to verify password is correct

            bool isPasswordValid = PBKDF2.Verify(result.PasswordHash, pass);

            if(isPasswordValid)
            {
                return result;
            } else
            {
                return null;
            }
            

        }

        public async Task<Account> Deposit(int accountId, double amount)
        {
            return await _unitOfWork.Accounts.AddBalance(accountId, amount);
        }

        public async Task<Account> Withdraw(int accountId, double amount)
        {
            return await _unitOfWork.Accounts.RemoveBalance(accountId, amount);
        }

        public Task<Login> Logout()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> MyProfile(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Account>> MyStatements(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<Transaction> Transfer(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BillPay>> BillPay()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Account>> DisplayAccounts(int accountId)
        {

            var result = await _unitOfWork.Accounts.GetAccountsByCustomerId(accountId);


            //ADD login to add up value of all transactions

            return result;
        }
    }
}
