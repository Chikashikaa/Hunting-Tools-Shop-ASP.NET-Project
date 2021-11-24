using FluentValidation;
using System;

namespace HTSP.Application.Features.Queries.OrderLineQuery
{
    public class GetOrderLineQueryValidator : AbstractValidator<GetOrderLineQuery>
    {
        public GetOrderLineQueryValidator()
        {
            RuleFor(orderline =>
            orderline.OrderLineID).NotEqual(Guid.Empty);
        }
    }
}
