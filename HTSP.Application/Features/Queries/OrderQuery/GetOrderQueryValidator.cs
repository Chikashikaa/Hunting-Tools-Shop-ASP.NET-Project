using FluentValidation;
using System;

namespace HTSP.Application.Features.Queries.OrderQuery
{
    public class GetOrderQueryValidator : AbstractValidator<GetOrderQuery>
    {
        public GetOrderQueryValidator()
        {
            RuleFor(order =>
            order.OrderID).NotEqual(Guid.Empty);
        }
    }
}
