using Mc2.CrudTest.Domain.Customers;
using Mc2.CrudTest.Domain.Models;
using Mc2.CrudTest.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Infrastructure.Customers
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerDbContext _dbContext;
        public CustomerRepository(CustomerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddCustomerAsync(Customer customer, CancellationToken cancellationToken)
        {
            _dbContext.Customers.Add(customer);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteCustomerAsync(Customer customer, CancellationToken cancellationToken)
        {
            _dbContext.Customers.Remove(customer);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task<Customer> GetCustomerAsync(int id, CancellationToken cancellationToken)
        {
          return  await _dbContext.Customers.SingleOrDefaultAsync(x => x.Id == id, cancellationToken);
            
        }

        public async Task UpdateCustomerAsync(Customer customer, CancellationToken cancellationToken)
        {
             _dbContext.Customers.Update(customer);
           await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
