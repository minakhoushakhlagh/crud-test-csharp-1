using FluentValidation;

namespace Mc2.CrudTest.Application.Requests.DeleteCustomer
{
    public class DeleteCustomerValidator : AbstractValidator<DeleteCustomerRequest>
    {
        public DeleteCustomerValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
