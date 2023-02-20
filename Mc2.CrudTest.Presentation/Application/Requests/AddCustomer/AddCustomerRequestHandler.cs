using Mc2.CrudTest.Domain.Customers;
using Mc2.CrudTest.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Application.Requests.AddCustomer
{
    public class AddCustomerRequestHandler : IRequestHandler <AddCustomerRequest>
    {
        private readonly ICustomerRepository _customerRepository;
        public AddCustomerRequestHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;    
        }
        public async Task<Unit> Handle(AddCustomerRequest request, CancellationToken cancellationToken)
        {
            await _customerRepository.AddCustomerAsync(new Customer
            {
                BankAccountNumber = request.BankAccountNumber,  
                DateOfBirth = request.DateOfBirth,  
                Email = request.Email,
                Firstname = request.Firstname,
                Lastname = request.Lastname,    
                PhoneNumber = request.PhoneNumber,
            },cancellationToken);

            return Unit.Value;
        }
    }
}
