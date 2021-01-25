using AutoMapper;
using Pod.Core.Domain;
using Pod.Web.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pod.Web.Mapper
{
    public class PaymentRequestMapper:Profile
    {
        public PaymentRequestMapper()
        {
            CreateMap<PaymentRequest, ProcessPaymentDto>().ReverseMap();
        }
    }
}
