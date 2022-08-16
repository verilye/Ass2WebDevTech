using Ass2WebTech.Core.Interfaces;
using Ass2WebTech.Models;
using Microsoft.EntityFrameworkCore;

namespace Ass2WebTech.Data.Repositories
{
    public class PayeeRepository : IPayeeRepository
    {
        private readonly BankContext _context;

        public PayeeRepository(BankContext context) 
        { 
            _context = context;
        }

        public Task<Payee> GetPayeeById()
        {
            throw new NotImplementedException();
        }
    }
}