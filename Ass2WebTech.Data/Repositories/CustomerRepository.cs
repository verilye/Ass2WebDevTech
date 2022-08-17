using Ass2WebTech.Core.Interfaces;
using Ass2WebTech.Models;
using Microsoft.EntityFrameworkCore;

namespace Ass2WebTech.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly BankContext _context;

        public CustomerRepository(BankContext context) 
        { 
            _context = context;
        }

        public async Task<Customer> CreateCustomer(Customer customer)
        {  
             
            await _context.Customers
                .AddAsync(customer);

            return customer;
        }

        public Task<Customer> GetCustomerById()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> UpdateCustomer()
        {
            throw new NotImplementedException();
        }
    }
}