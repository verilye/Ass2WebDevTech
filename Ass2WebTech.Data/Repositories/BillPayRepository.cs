using Ass2WebTech.Core.Interfaces;
using Ass2WebTech.Models;
using Microsoft.EntityFrameworkCore;

namespace Ass2WebTech.Data.Repositories
{
    public class BillPayRepository : IBillPayRepository
    {
        private readonly BankContext _context;

        public BillPayRepository(BankContext context) 
        { 
            _context = context;
        }

        public Task<BillPay> CreateBillPay()
        {
            throw new NotImplementedException();
        }

        public Task<BillPay> GetAllBillPaysByAccountNumber()
        {
            throw new NotImplementedException();
        }

        public Task<BillPay> GetBillPayById()
        {
            throw new NotImplementedException();
        }

        public Task<BillPay> UpdateBillPay()
        {
            throw new NotImplementedException();
        }
    }
}