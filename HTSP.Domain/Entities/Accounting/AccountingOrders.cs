using System;
using System.Collections.Generic;

namespace HTSP.Domain.Entities.Accounting
{
    public class AccountingOrders
    {
        public string AOrNaming { get; set; }
        public string AOrDescription { get; set; }
        public List<Guid> OrderID { get; set; }
    }
}
