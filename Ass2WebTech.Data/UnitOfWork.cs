using Ass2WebTech.Core;
using Ass2WebTech.Core.Interfaces;
using Ass2WebTech.Data.Repositories;

namespace Ass2WebTech.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BankContext _context;
        private AccountRepository _accountRepository;
        

        public IAccountRepository Accounts => _accountRepository = _accountRepository ?? new AccountRepository(_context);

        public IBillPayRepository BillPays => throw new NotImplementedException();

        public ICustomerRepository Customers => throw new NotImplementedException();

        public ILoginRepository Logins => throw new NotImplementedException();

        public IPayeeRepository Payees => throw new NotImplementedException();

        public ITransactionRepository Transactions => throw new NotImplementedException();

        public Task<int> CommitAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}