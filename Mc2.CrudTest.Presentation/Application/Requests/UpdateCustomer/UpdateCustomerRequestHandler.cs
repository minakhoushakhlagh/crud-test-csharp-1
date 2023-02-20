using Mc2.CrudTest.Domain.Customers;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Application.Requests.UpdateCustomer
{
    public class UpdateCustomerRequestHandler : IRequestHandler<UpdateCustomerRequest>
    {
        private readonly ICustomerRepository _customerRepository;
        public UpdateCustomerRequestHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task<Unit> Handle(UpdateCustomerRequest request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetCustomerAsync(request.Id, cancellationToken);
            if (customer == null)
            {
                throw new Exception($"Customer With Id {request.Id} Not Found");
            }

            customer.Firstname = request.Firstname;
            customer.Lastname = request.Lastname;
            customer.DateOfBirth = request.DateOfBirth;
            customer.Email = request.Email;
            customer.PhoneNumber = request.PhoneNumber;
            customer.BankAccountNumber = request.BankAccountNumber; 

            await _customerRepository.UpdateCustomerAsync(customer, cancellationToken);

            return Unit.Value;
        }
    }
}
