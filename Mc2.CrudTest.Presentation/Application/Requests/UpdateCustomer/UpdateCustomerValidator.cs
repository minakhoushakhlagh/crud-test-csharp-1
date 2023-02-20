using FluentValidation;

namespace Mc2.CrudTest.Application.Requests.UpdateCustomer
{
    public class UpdateCustomerValidator : AbstractValidator<UpdateCustomerRequest>
    {
        public UpdateCustomerValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}

