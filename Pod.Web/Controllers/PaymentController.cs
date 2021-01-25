using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pod.Application.Repository;
using Pod.Core.Domain;
using Pod.Core.Enum;
using Pod.Shared.Response;
using Pod.Web.Dto;
using Pod.Web.Framework;

namespace Pod.Web.Controllers
{
    [Route("ProcessPayment")]
    [ApiController]
    public class PaymentController : BaseController
    {
        private IRepositoryWrapper _repoWrapper;
        private readonly IMapper _mapper;
        private CommonResponse _CommonResponse;

        public PaymentController(IRepositoryWrapper repoWrapper, IMapper mapper)
        {
            _repoWrapper = repoWrapper;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Response(_repoWrapper.CheapPaymentGateway.GetData());
        }
            [HttpPost]

        public IActionResult Post([FromForm] ProcessPaymentDto requestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            

            var Request = _mapper.Map<PaymentRequest>(requestDto);
            Request.PaymentState = new PaymentStates(Guid.NewGuid(), PaymentStatus.Pending);
            if( requestDto.Amount < 20)
                _CommonResponse = _repoWrapper.CheapPaymentGateway.Create(Request);
            if (requestDto.Amount > 20  && requestDto.Amount < 500)
                _CommonResponse = _repoWrapper.expensivePaymentGateway.Create(Request);
            else
                _CommonResponse = _repoWrapper.PremiumPaymentGateway.Create(Request);
            
            _CommonResponse =   _repoWrapper.CheapPaymentGateway.Create(Request);
            _repoWrapper.Save();
                return Response(_CommonResponse);

        }
    }
}
