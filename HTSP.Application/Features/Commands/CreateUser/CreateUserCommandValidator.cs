using FluentValidation;
using System;

namespace HTSP.Application.Features.Commands.CreateUser
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(createUserCommand =>
            createUserCommand.UserID).NotEqual(Guid.Empty);
            RuleFor(createAccountCommand =>
            createAccountCommand.AccountID).NotEqual(Guid.Empty);
            RuleFor(createUserCommand =>
            createUserCommand.UserName).NotEmpty().MaximumLength(50);
            RuleFor(createUserCommand =>
            createUserCommand.UserLastName).NotEmpty().MaximumLength(100);
            RuleFor(createUserCommand =>
            createUserCommand.UserPhoneNumber).NotEmpty().MaximumLength(15).MinimumLength(10);
            RuleFor(createUserCommand =>
            createUserCommand.UserLogin).NotEmpty().MaximumLength(50).MinimumLength(2);
            RuleFor(createUserCommand =>
            createUserCommand.UserPassword).NotEmpty().MaximumLength(50).MinimumLength(6);
        }
    }
}
