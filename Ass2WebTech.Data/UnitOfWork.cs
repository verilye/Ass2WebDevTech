using Ass2WebTech.Core.Interfaces;

namespace Ass2WebTech.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BankContext _context;
        
        private AccountRepository _accountRepository;


    }
}