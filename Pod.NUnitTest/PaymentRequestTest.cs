using NUnit.Framework;
using Pod.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pod.NUnitTest
{
    class PaymentRequestTest
    {
        PaymentRequest PaymentRequest;
        [SetUp]
        public void Setup()
        {
            PaymentRequest PaymentRequest = new PaymentRequest()
            {
                Amount = 10,
                CardHolder = "Jhon",
                CreditCardNumber = "1234567812345678",
                ExpirationDate = Convert.ToDateTime("10/2030"),
                SecurityCode = "222"
            };
        }
        [Test]
        public void AddPaymentRequest()
        {
        }
        }
}
