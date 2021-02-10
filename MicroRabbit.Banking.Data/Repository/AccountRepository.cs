using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace MicroRabbit.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private BankingDbContext bankingDbContext;
        private DbSet<Account> accounts;

        public AccountRepository(BankingDbContext bankingDbContext)
        {
            this.bankingDbContext = bankingDbContext;
            accounts = bankingDbContext.Set<Account>();
        }

        public IEnumerable<Account> Accounts()
        {
            return accounts.ToList();
        }
    }
}
