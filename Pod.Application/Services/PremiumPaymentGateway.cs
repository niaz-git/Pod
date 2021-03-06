﻿using Pod.Application.Interfaces;
using Pod.Application.Repository;
using Pod.Core.Domain;
using Pod.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pod.Application.Services
{
 public   class PremiumPaymentGateway : RepositoryBase<PaymentRequest>, IPremiumPaymentGateway
    {
        public PremiumPaymentGateway(PodContext repositoryContext)
            : base(repositoryContext)
        {

        }
    }
}


