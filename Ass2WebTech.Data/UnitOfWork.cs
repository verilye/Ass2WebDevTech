using Ass2WebTech.Core;
using Ass2WebTech.Core.Interfaces;
using Ass2WebTech.Data.Repositories;

namespace Ass2WebTech.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BankContext _context;
        private AccountRepository _accountRepository;
        private LoginRepository _loginRepository;
        private BillPayRepository _billPayRepository;
        private CustomerRepository _customerRepository;
        private PayeeRepository _payeeRepository;
        private TransactionRepository _transactionRepository;

        public UnitOfWork(BankContext context)
        {
            _context = context;
        }
        

        public IAccountRepository Accounts => _accountRepository = _accountRepository ?? new AccountRepository(_context);

        public IBillPayRepository BillPays => _billPayRepository = _billPayRepository ?? new BillPayRepository(_context);

        public ICustomerRepository Customers => _customerRepository = _customerRepository ?? new CustomerRepository(_context);

        public ILoginRepository Logins => _loginRepository = _loginRepository ?? new LoginRepository(_context);

        public IPayeeRepository Payees => _payeeRepository = _payeeRepository ?? new PayeeRepository(_context);

        public ITransactionRepository Transactions => _transactionRepository = _transactionRepository ?? new TransactionRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}