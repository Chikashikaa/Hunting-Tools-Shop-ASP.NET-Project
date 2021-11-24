using AutoMapper;
using AutoMapper.QueryableExtensions;
using HTSP.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HTSP.Application.Features.Queries.OrderLineListQuery
{
    public class GetOrderLineListQueryHandler
    : IRequestHandler<GetOrderLineListQuery, OrderLineListVm>
    {
        private readonly IHTSPDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetOrderLineListQueryHandler(IHTSPDbContext dbContext, IMapper mapper) =>
            (_dbContext, _mapper) = (dbContext, mapper);
        public async Task<OrderLineListVm> Handle(GetOrderLineListQuery GetRequest, CancellationToken cancellationToken)
        {
            var orderlines = await _dbContext.OrderLines
                .Where(orderlines => orderlines.OrderLineID == GetRequest.OrderLineID)
                .ProjectTo<OrderLineListLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new OrderLineListVm { OrderLines = orderlines };
        }
    }
}
