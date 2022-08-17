using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ass2WebTech.Models;

namespace Ass2WebTech.Core.Interfaces
{
    public interface ICustomerRepository
    {
        Task<Customer> GetCustomerById();
        Task<Customer> UpdateCustomer();
        Task<Customer> CreateCustomer(Customer customer);
        bool CheckForCustomers();
    }
}