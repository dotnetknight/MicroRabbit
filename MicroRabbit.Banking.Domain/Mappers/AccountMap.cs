using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MicroRabbit.Banking.Domain.Mappers
{
    public class AccountMap
    {
        public AccountMap(EntityTypeBuilder<Account> entityBuilder)
        {
            entityBuilder.HasKey(p => p.Id);

            entityBuilder.Property(p => p.AccountBalance)
                .IsRequired();

            entityBuilder.Property(p => p.AccountType)
                .IsRequired();
        }
    }
}
