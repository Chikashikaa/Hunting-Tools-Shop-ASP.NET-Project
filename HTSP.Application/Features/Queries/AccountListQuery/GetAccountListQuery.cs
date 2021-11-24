using MediatR;
using System;

namespace HTSP.Application.Features.Queries.AccountListQuery
{
    public class GetAccountListQuery : IRequest <AccountListVm>
    {
        public Guid AccountID { get; set; }
    }
}
