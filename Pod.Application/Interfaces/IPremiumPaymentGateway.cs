using Pod.Application.Repository;
using Pod.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pod.Application.Interfaces
{
    public interface IPremiumPaymentGateway : IRepositoryBase<PaymentRequest>
    {
    }
}