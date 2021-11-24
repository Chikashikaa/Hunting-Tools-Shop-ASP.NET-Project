using System;

namespace HTSP.Domain.Entities.Accounting
{
    public class AccountingOneOrder
    {
        public string AOOrNaming { get; set; }
        public string AOOrDescription { get; set; }
        public Guid OrderID { get; set; }
    }
}
