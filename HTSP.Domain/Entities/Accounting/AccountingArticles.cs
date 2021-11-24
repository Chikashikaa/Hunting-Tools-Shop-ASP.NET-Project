using System;
using System.Collections.Generic;

namespace HTSP.Domain.Entities.Accounting
{
    public class AccountingArticles
    {
        public string AANaming { get; set; }
        public string AADescription { get; set; }
        public List<Guid> ArticleID { get; set; }
    }
}
