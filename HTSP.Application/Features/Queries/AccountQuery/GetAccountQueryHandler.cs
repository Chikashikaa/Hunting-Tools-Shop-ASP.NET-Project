using AutoMapper;
using HTSP.Application.Features.Exceptions;
using HTSP.Application.Interfaces;
using HTSP.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace HTSP.Application.Features.Queries.AccountQuery
{
    public class GetAccountQueryHandler
        : IRequestHandler<GetAccountQuery, AccountVm>
    {
        private readonly IHTSPDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetAccountQueryHandler(IHTSPDbContext dbContext, IMapper mapper) =>
            (_dbContext, _mapper) = (dbContext, mapper);
        public async Task<AccountVm> Handle(GetAccountQuery GetRequest, CancellationToken cancellationToken)
        {
            var account = await _dbContext.Accounts
                .FirstOrDefaultAsync(account => account.AccountID == GetRequest.AccountID, cancellationToken);
            if (account == null || account.AccountID != GetRequest.AccountID)
            {
                throw new NotFoundException(nameof(Account), GetRequest.AccountID);
            }
            return _mapper.Map<AccountVm>(account);
        }
    }
}
