using FluentValidation;

namespace Mc2.CrudTest.Application.Requests.GetCustomer
{
    public class GetCustomerValidator : AbstractValidator<GetCustomerRequest>
    {
        public GetCustomerValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
