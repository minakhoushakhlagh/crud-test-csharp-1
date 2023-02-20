using Mc2.CrudTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Domain.Customers
{
    public interface ICustomerRepository
    {
        Task AddCustomerAsync(Customer customer, CancellationToken cancellationToken);

        Task<Customer> GetCustomerAsync(int id, CancellationToken cancellationToken);

        Task UpdateCustomerAsync(Customer customer, CancellationToken cancellationToken);

        Task DeleteCustomerAsync(Customer customer, CancellationToken cancellationToken);

    }
}
