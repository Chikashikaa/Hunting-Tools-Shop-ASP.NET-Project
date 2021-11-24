using FluentValidation;
using System;

namespace HTSP.Application.Features.Queries.OrderLineListQuery
{
    public class GetOrderLineListQueryValidator : AbstractValidator<GetOrderLineListQuery>
    {
        public GetOrderLineListQueryValidator()
        {
            RuleFor(orderline =>
            orderline.OrderLineID).NotEqual(Guid.Empty);
        }
    }
}

