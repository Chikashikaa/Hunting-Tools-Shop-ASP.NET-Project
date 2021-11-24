using System.Collections.Generic;

namespace HTSP.Application.Features.Queries.AccountListQuery
{
    public class AccountListVm
    {
        public IList<AccountListLookupDto> Accounts { get; set; }
    }
}
