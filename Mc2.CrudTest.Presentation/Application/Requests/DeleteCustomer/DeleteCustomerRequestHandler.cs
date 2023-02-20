using Mc2.CrudTest.Domain.Customers;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Application.Requests.DeleteCustomer
{
    public class DeleteCustomerRequestHandler : IRequestHandler<DeleteCustomerRequest>
    {
        private readonly ICustomerRepository _customerRepository;
        public DeleteCustomerRequestHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task<Unit> Handle(DeleteCustomerRequest request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetCustomerAsync(request.Id, cancellationToken);
            if (customer == null)
            {
                throw new Exception($"Customer With Id {request.Id} Not Found");
            }

            await _customerRepository.DeleteCustomerAsync(customer, cancellationToken);

            return Unit.Value;
        }
    }
}
