using Microsoft.EntityFrameworkCore;
using Pod.Core.Domain;
using Pod.Core.Infrastructure.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pod.Core.Infrastructure
{
  public  class PodContext:DbContext
    {
        public DbSet<PaymentRequest> PaymentRequest { get; set; }
        public PodContext(DbContextOptions<PodContext> options): base(options)
        {

        }
        public PodContext()
        {

        }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.ApplyConfiguration(new PaymentRequestConfiguration());
            mb.ApplyConfiguration(new PaymentStateCofiguration());

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-MR2OR178\SQLEXPRESS;Initial Catalog=PaymentDomainDb;User ID=sa;pwd=123456");
            }
        }
    }
    }
