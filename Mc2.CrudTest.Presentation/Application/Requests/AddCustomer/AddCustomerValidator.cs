using FluentValidation;

namespace Mc2.CrudTest.Application.Requests.AddCustomer
{
    public class AddCustomerValidator:AbstractValidator<AddCustomerRequest>
    {
        public AddCustomerValidator()
        {
            RuleFor(x => x.Firstname).NotEmpty();
            RuleFor(x => x.Lastname).NotEmpty();
            RuleFor(x => x.Email).EmailAddress();
            RuleFor(x => x.PhoneNumber).NotEmpty().PhoneNumber();

        }
    }
}
