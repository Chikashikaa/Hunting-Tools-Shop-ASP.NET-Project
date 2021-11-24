using MediatR;
using System;

namespace HTSP.Application.Features.Queries.AccountQuery
{
    public class GetAccountQuery : IRequest<AccountVm>
    {
        public Guid AccountID { get; set; }
    }
}
