using Pod.Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pod.Core.Domain
{
  public  class PaymentStates
    {
        public PaymentStates()
        {

        }
        public PaymentStates(Guid statusID, PaymentStatus paymentStatus)
        {
            this.PaymentStatusId = statusID;
            this.PaymentStatus = paymentStatus;
        }
        public Guid PaymentStatusId { get; set; }
        public PaymentStatus PaymentStatus { get; set; }

        public virtual PaymentRequest PaymentRequest { get; set; }

        public void ChangeState(PaymentStatus paymentStatus)
        {
            this.PaymentStatus = paymentStatus;
        }

    }
}
