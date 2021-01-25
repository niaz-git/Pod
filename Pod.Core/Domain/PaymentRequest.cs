using System;
using System.Collections.Generic;
using System.Text;

namespace Pod.Core.Domain
{
  public  class PaymentRequest
    {
        public Guid RequestId { get; set; }
        public string CreditCardNumber { get; set; }
        public string CardHolder { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string SecurityCode { get; set; }
        public decimal Amount { get; set; }
        public DateTime RequestDate { get; set; }
        public Guid  PaymentStateId { get; set; }
        public virtual  PaymentStates PaymentState { get; set; }
    }
}
