using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Ass2WebTech.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {  
        // A unit of work is one operation carried out on the database
        // requested from the controller in a different layer

        //It is inherited by all repository interfaces

        IAccountRepository Accounts {get;}
        IBillPayRepository BillPays {get;}
        ICustomerRepository Customers {get;}
        ILoginRepository Logins {get;}
        IPayeeRepository Payees {get;}
        ITransactionRepository Transactions {get;}

        // Included in unit of work example, look into the keyword further
        Task<int> CommitAsync();
        
    }
}