using FluentValidation;
using System;

namespace HTSP.Application.Features.Queries.AccountQuery
{
    public class GetAccountQueryValidator : AbstractValidator<GetAccountQuery>
    {
        public GetAccountQueryValidator()
        {
            RuleFor(account =>
            account.AccountID).NotEqual(Guid.Empty);
        }
    }
}
