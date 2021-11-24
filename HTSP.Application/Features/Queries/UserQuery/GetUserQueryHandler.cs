using AutoMapper;
using HTSP.Application.Features.Exceptions;
using HTSP.Application.Interfaces;
using HTSP.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace HTSP.Application.Features.Queries.UserQuery
{
    public class GetUserQueryHandler
        : IRequestHandler<GetUserQuery, UserVm>
    {
        private readonly IHTSPDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetUserQueryHandler(IHTSPDbContext dbContext, IMapper mapper) =>
            (_dbContext, _mapper) = (dbContext, mapper);
        public async Task<UserVm> Handle(GetUserQuery GetRequest, CancellationToken cancellationToken)
        {
            var user = await _dbContext.Users
                .FirstOrDefaultAsync(user => user.UserID == GetRequest.UserID, cancellationToken);
            if (user == null || user.UserID != GetRequest.UserID)
            {
                throw new NotFoundException(nameof(User), GetRequest.UserID);
            }
            return _mapper.Map<UserVm>(user);
        }
    }
}
