using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Application.Behaviors
{
    public class ValidatorBehavior<TRequest,TResponse>:IPipelineBehavior<TRequest, TResponse>
    {
        private readonly  IValidator<TRequest> _validator;
        public ValidatorBehavior(IValidator<TRequest> validator)
        {
            _validator = validator;
        }
        public ValidatorBehavior()
        {

        }
        public Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            if (_validator !=null)
            {
                var result = _validator.Validate(request);
                if (!result.IsValid)
                {
                    var modelstate = new ModelStateDictionary();
                    result.AddToModelState(modelstate, string.Empty);
                    throw new Exception(string.Join(",",result.Errors));
                }
                
            }
            return next();
        }
    }
}
