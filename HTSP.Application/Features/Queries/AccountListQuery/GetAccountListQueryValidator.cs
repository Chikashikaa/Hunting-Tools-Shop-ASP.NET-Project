using FluentValidation;
using System;

namespace HTSP.Application.Features.Queries.AccountListQuery
{
    public class GetAccountListQueryValidator : AbstractValidator<GetAccountListQuery>
    {
        public GetAccountListQueryValidator()
        {
            RuleFor(account =>
            account.AccountID).NotEqual(Guid.Empty);
        }
    }
}
