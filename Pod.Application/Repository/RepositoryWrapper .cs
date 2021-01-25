using Pod.Application.Interfaces;
using Pod.Application.Services;
using Pod.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pod.Application.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private PodContext _repoContext;
        private ICheapPaymentGateway _cheapPaymentGateway;
        private IExpensivePaymentGateway _expensivePaymentGateway;
        private IPremiumPaymentGateway _premiumPaymentGateway;



        public RepositoryWrapper(PodContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public ICheapPaymentGateway CheapPaymentGateway
        {
            get
            {
                if (_cheapPaymentGateway == null)
                {
                    _cheapPaymentGateway = new CheapPaymentGateway(_repoContext);
                }
                return _cheapPaymentGateway;
            }
        }

        public IExpensivePaymentGateway expensivePaymentGateway
        {
            get
            {
                if (_expensivePaymentGateway == null)
                {
                    _expensivePaymentGateway = new ExpensivePaymentGateway(_repoContext);
                }
                return _expensivePaymentGateway;
            }
        }

        public IPremiumPaymentGateway PremiumPaymentGateway
        {
            get
            {
                if (_premiumPaymentGateway == null)
                {
                    _premiumPaymentGateway = new PremiumPaymentGateway(_repoContext);
                }
                return _premiumPaymentGateway;
            }
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}   