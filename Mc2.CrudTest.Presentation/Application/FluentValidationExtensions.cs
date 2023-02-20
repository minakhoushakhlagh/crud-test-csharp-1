using FluentValidation;


namespace Mc2.CrudTest.Application
{
    public static class FluentValidationExtensions
    {
        public static IRuleBuilderOptions<T, string> PhoneNumber<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.Must(x => Domain.PhoneNumber.TryParse(x, out _));
        }
    }
}
