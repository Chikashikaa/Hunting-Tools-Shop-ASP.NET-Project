using System.Collections.Generic;

namespace HTSP.Application.Features.Queries.OrderListQuery
{
    public class OrderListVm
    {
        public IList<OrderListLookupDto> Orders { get; set; }
    }
}
