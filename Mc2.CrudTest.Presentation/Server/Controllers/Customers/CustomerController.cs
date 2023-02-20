using Mc2.CrudTest.Application.Requests.AddCustomer;
using Mc2.CrudTest.Application.Requests.DeleteCustomer;
using Mc2.CrudTest.Application.Requests.GetCustomer;
using Mc2.CrudTest.Application.Requests.UpdateCustomer;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Presentation.Server.Controllers.Customers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        /// <summary>
        /// add customer
        /// </summary>
        [Route("add")]
        [HttpPost]
        public async Task AddCustomer(AddCustomerRequest request)
        {
            await _mediator.Send(request,HttpContext.RequestAborted); 
        }

        /// <summary>
        /// get customer
        /// </summary>
        [Route("get")]
        [HttpGet]
        public async Task<GetCustomerResponse> GetCustomer([FromQuery]GetCustomerRequest request)
        {
            return await _mediator.Send(request, HttpContext.RequestAborted);

        }

        /// <summary>
        /// update customer
        /// </summary>
        [Route("update")]
        [HttpPost]
        public async Task UpdateCustomer(UpdateCustomerRequest request)
        {
            await _mediator.Send(request, HttpContext.RequestAborted);

        }

        /// <summary>
        /// delete customer
        /// </summary>
        [Route("delete")]
        [HttpDelete]
        public async Task DeleteCustomer([FromQuery] DeleteCustomerRequest request)
        {
            await _mediator.Send(request, HttpContext.RequestAborted);

        }
    }
}
