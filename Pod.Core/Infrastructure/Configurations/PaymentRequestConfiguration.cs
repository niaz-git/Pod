using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pod.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pod.Core.Infrastructure.Configurations
{
  public  class PaymentRequestConfiguration: IEntityTypeConfiguration<PaymentRequest>
    {
        public void Configure(EntityTypeBuilder<PaymentRequest> builder)
        {
            builder.HasKey(x => x.RequestId);
            builder.Property(x => x.CardHolder).IsRequired();
            builder.Property(x => x.CreditCardNumber).IsRequired().HasMaxLength(16);
            builder.Property(x => x.ExpirationDate).IsRequired();
            builder.Property(x => x.SecurityCode).HasMaxLength(3);
            builder.Property(x => x.Amount).IsRequired()
                        .HasColumnType("decimal(18,2)");
            builder.HasOne(x => x.PaymentState).WithOne().HasForeignKey<PaymentRequest>(x=>x.PaymentStateId);
        }
    }
}
