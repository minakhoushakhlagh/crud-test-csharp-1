using Mc2.CrudTest.Domain.Customers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Application.Requests.GetCustomer
{
    public class GetCustomerRequestHandler : IRequestHandler<GetCustomerRequest, GetCustomerResponse>
    {
        private readonly ICustomerRepository _customerRepository;
        public GetCustomerRequestHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<GetCustomerResponse> Handle(GetCustomerRequest request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetCustomerAsync(request.Id, cancellationToken);
            if (customer == null)
            {
                throw new Exception($"Customer With Id {request.Id} Not Found");
            }

            return new GetCustomerResponse 
            {
                FirstName = customer.Firstname,
                LastName = customer.Lastname,
                DateOfBirth = customer.DateOfBirth, 
                PhoneNumber = customer.PhoneNumber,
                Email = customer.Email,
                BankAccountNumber = customer.BankAccountNumber,
            };
        }
    }
}
