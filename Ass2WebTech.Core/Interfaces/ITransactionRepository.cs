using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ass2WebTech.Models;

namespace Ass2WebTech.Core.Interfaces
{
    public interface ITransactionRepository
    {
        Task<Transaction> GetTransactionById();
        Task<Transaction> GetAllTransactionsByAccount();
        Task<Transaction> CreateTransaction(Transaction transaction);

    }
}