using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pod.Web.Dto
{
    public class ProcessPaymentDto
    {
        [Required]
        [StringLength(16, MinimumLength = 16)]

        public string CreditCardNumber { get; set; }
        [Required]
        public string CardHolder { get; set; }
        [Required]
        public DateTime ExpirationDate { get; set; }
        public string SecurityCode { get; set; }
        [Required]
        public decimal Amount { get; set; }
    }
}
