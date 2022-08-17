using Ass2WebTech.Models;
using Microsoft.EntityFrameworkCore;

namespace Ass2WebTech.Data
{
    public class BankContext : DbContext
    {

        public BankContext(DbContextOptions<BankContext> options)
                : base(options)
        { }
        
        public DbSet<Account> Accounts { get; set; }
        public DbSet<BillPay> BillPays { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Payee> Payees { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

                modelBuilder.Entity<Transaction>()
                        .HasOne(a => a.Account)
                        .WithMany(t => t.Transactions)
                        .HasForeignKey(a => a.AccountNumber)
                        .OnDelete(DeleteBehavior.NoAction);

                modelBuilder.Entity<Transaction>()
                        .HasOne(a => a.DestinationAccount)
                        .WithMany(t => t.DestinationAccountNumbers)
                        .HasForeignKey(a => a.DestinationAccountNumber)
                        .OnDelete(DeleteBehavior.NoAction);

                modelBuilder.Entity<BillPay>()
                        .HasOne(a => a.Account)
                        .WithMany(t => t.BillPays)
                        .HasForeignKey(t => t.AccountNumber)
                        .OnDelete(DeleteBehavior.NoAction);
        }


        //  modelBuilder.Entity<Account>();
        //     modelBuilder.Entity<BillPay>();
        //     modelBuilder.Entity<Customer>();
        //     modelBuilder.Entity<Login>();
        //     modelBuilder.Entity<Payee>();
        //     modelBuilder.Entity<Transaction>();


    }
}  