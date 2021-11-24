using System.Collections.Generic;

namespace HTSP.Application.Features.Queries.OrderLineListQuery
{
    public class OrderLineListVm
    {
        public IList<OrderLineListLookupDto> OrderLines { get; set; }
    }
}
