using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Domain.Mappers
{
    public class TransferMap
    {
        public TransferMap(EntityTypeBuilder<TransferLog> entityBuilder)
        {
            entityBuilder.HasKey(p => p.Id);

            entityBuilder.Property(p => p.ToAccount)
               .IsRequired();

            entityBuilder.Property(p => p.FromAccount)
              .IsRequired();

            entityBuilder.Property(p => p.TransferAmount)
                .IsRequired();
        }
    }
}
