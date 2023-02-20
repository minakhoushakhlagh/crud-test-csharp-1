using FluentValidation;
using Mc2.CrudTest.Application.Behaviors;
using Mc2.CrudTest.Application.Requests.AddCustomer;
using Mc2.CrudTest.Application.Requests.DeleteCustomer;
using Mc2.CrudTest.Application.Requests.GetCustomer;
using Mc2.CrudTest.Application.Requests.UpdateCustomer;
using Mc2.CrudTest.Domain.Context;
using Mc2.CrudTest.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Mc2.CrudTest.Presentation.Server.Services
{
    public static class ServiceExtensions
    {
        public static void AddSqlConnection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ICustomerDbContext, CustomerDbContext>(option =>
            {
                option.UseSqlServer(configuration["ConnectionString:connection"]);
            });
        }
        public static void AddValidators(this IServiceCollection services)
        {
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidatorBehavior<,>));
            services.AddTransient<IValidator<AddCustomerRequest>, AddCustomerValidator>();
            services.AddTransient<IValidator<GetCustomerRequest>, GetCustomerValidator>();
            services.AddTransient<IValidator<UpdateCustomerRequest>, UpdateCustomerValidator>();
            services.AddTransient<IValidator<DeleteCustomerRequest>, DeleteCustomerValidator>();
        }
    }
}
