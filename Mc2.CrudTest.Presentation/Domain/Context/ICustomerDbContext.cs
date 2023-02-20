using Mc2.CrudTest.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Mc2.CrudTest.Domain.Context
{
    public interface ICustomerDbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}
