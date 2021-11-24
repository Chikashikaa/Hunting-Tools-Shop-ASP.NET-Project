using System;

namespace HTSP.Domain.Entities.Accounting
{
    public class AccountingOneArticle
    {
        public string AOANaming { get; set; }
        public string AOADescription { get; set; }
        public Guid ArticleID { get; set; }
    }
}
