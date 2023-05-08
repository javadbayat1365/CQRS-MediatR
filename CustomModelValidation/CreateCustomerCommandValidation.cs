using FluentValidation;
using MediatR_CQRS.Commands;

namespace MediatR_CQRS.CustomModelValidation
{
    public class CreateCustomerCommandValidation:AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidation()
        {
            RuleFor(r => r.FName).NotEmpty().MaximumLength(100).NotEqual("test");
            RuleFor(r => r.LName).NotEmpty().MinimumLength(3).MaximumLength(100) 
                .NotEqual(n => n.FName,StringComparer.OrdinalIgnoreCase);
        }
    }
}
