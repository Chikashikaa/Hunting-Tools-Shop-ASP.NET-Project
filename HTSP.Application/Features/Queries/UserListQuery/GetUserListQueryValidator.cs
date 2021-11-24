using FluentValidation;
using System;

namespace HTSP.Application.Features.Queries.UserListQuery
{
    public class GetUserListQueryValidator : AbstractValidator<GetUserListQuery>
    {
        public GetUserListQueryValidator()
        {
            RuleFor(user =>
            user.UserID).NotEqual(Guid.Empty);
        }
    }
}
