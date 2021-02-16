using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDbContext transferDbContext;
        private DbSet<TransferLog> transferLogs;

        public TransferRepository(TransferDbContext transferDbContext)
        {
            this.transferDbContext = transferDbContext;
            transferLogs = transferDbContext.Set<TransferLog>();
        }

        public void Add(TransferLog transferLog)
        {
            transferLogs.Add(transferLog);
            transferDbContext.SaveChanges();
        }

        public IEnumerable<TransferLog> TransferLogs()
        {
            return transferLogs.ToList();
        }
    }
}
