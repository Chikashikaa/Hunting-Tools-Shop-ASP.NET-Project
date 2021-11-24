using AutoMapper;
using AutoMapper.QueryableExtensions;
using HTSP.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HTSP.Application.Features.Queries.UserListQuery
{
    public class GetUserListQueryHandler
        : IRequestHandler<GetUserListQuery, UserListVm>
    {
        private readonly IHTSPDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetUserListQueryHandler(IHTSPDbContext dbContext, IMapper mapper) =>
            (_dbContext, _mapper) = (dbContext, mapper);
        public async Task<UserListVm> Handle(GetUserListQuery GetRequest, CancellationToken cancellationToken)
        {
            var user = await _dbContext.Users
                .Where(user => user.UserID == GetRequest.UserID)
                .ProjectTo<UserListLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new UserListVm { Users = user };
        }
    }
}
