using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Application.Requests.GetCustomer
{
    public class GetCustomerRequest : IRequest<GetCustomerResponse>
    {
        public int Id { get; set; }
    }
}
