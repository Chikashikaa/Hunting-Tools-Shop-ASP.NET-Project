using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTSP.Application.Features.Queries.OrderListQuery
{
    public class GetOrderListQueryValidator : AbstractValidator<GetOrderListQuery>
    {
        public GetOrderListQueryValidator()
        {
            RuleFor(order =>
            order.OrderID).NotEqual(Guid.Empty);
        }
    }
}
