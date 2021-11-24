using FluentValidation;
using System;

namespace HTSP.Application.Features.Commands.DeleteUser
{
    public class DeleteUserCommandValidator : AbstractValidator<DeleteUserCommand>
    {
        public DeleteUserCommandValidator()
        {
            RuleFor(deleteUserCommand =>
            deleteUserCommand.UserID).NotEqual(Guid.Empty);
            RuleFor(deleteAccountCommand =>
            deleteAccountCommand.AccountID).NotEqual(Guid.Empty);
        }
    }
}
