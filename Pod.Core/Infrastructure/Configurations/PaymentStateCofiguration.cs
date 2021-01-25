using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pod.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pod.Core.Infrastructure.Configurations
{
    public class PaymentStateCofiguration: IEntityTypeConfiguration<PaymentStates>
    {
        public void Configure(EntityTypeBuilder<PaymentStates> builder)
        {
            builder.HasKey(x=>x.PaymentStatusId);

        }
    }
}
