using Ass2WebTech.Core.Interfaces;
using Ass2WebTech.Models;
using Microsoft.EntityFrameworkCore;

namespace Ass2WebTech.Data.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly BankContext _context;

        public TransactionRepository(BankContext context) 
        { 
            _context = context;
        }

        public Task<Transaction> CreateTransaction()
        {
            throw new NotImplementedException();
        }

        public Task<Transaction> GetAllTransactionsByAccount()
        {
            throw new NotImplementedException();
        }

        public Task<Transaction> GetTransactionById()
        {
            throw new NotImplementedException();
        }
    }
}