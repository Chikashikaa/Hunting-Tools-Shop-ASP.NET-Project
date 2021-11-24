using AutoMapper;
using AutoMapper.QueryableExtensions;
using HTSP.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HTSP.Application.Features.Queries.AccountListQuery
{
    public class GetAccountListQueryHandler
    : IRequestHandler<GetAccountListQuery, AccountListVm>
    {
        private readonly IHTSPDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetAccountListQueryHandler(IHTSPDbContext dbContext, IMapper mapper) =>
            (_dbContext, _mapper) = (dbContext, mapper);
        public async Task<AccountListVm> Handle(GetAccountListQuery GetRequest, CancellationToken cancellationToken)
        {
            var account = await _dbContext.Accounts
                .Where(account => account.AccountID == GetRequest.AccountID)
                .ProjectTo<AccountListLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new AccountListVm { Accounts = account };
        }
    }
}
