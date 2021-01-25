using Pod.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pod.Application.Repository
{
    public interface IRepositoryWrapper
    {
        ICheapPaymentGateway CheapPaymentGateway { get; }
        IExpensivePaymentGateway  expensivePaymentGateway { get; }
        IPremiumPaymentGateway PremiumPaymentGateway { get; }

        void Save();
    }
}
