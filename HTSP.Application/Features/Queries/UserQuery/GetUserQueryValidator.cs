using FluentValidation;
using System;

namespace HTSP.Application.Features.Queries.UserQuery
{
    public class GetUserQueryValidator : AbstractValidator<GetUserQuery>
    {
        public GetUserQueryValidator()
        {
            RuleFor(user =>
            user.UserID).NotEqual(Guid.Empty);
        }
    }
}
