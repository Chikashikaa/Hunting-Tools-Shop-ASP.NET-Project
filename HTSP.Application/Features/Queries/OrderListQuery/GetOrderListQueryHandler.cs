using AutoMapper;
using AutoMapper.QueryableExtensions;
using HTSP.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HTSP.Application.Features.Queries.OrderListQuery
{
    public class GetOrderListQueryHandler
        : IRequestHandler<GetOrderListQuery, OrderListVm>
    {
        private readonly IHTSPDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetOrderListQueryHandler(IHTSPDbContext dbContext, IMapper mapper) =>
            (_dbContext, _mapper) = (dbContext, mapper);
        public async Task<OrderListVm> Handle(GetOrderListQuery GetRequest, CancellationToken cancellationToken)
        {
            var order = await _dbContext.Orders
                .Where(order => order.OrderId == GetRequest.OrderID)
                .ProjectTo<OrderListLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new OrderListVm { Orders = order };
        }
    }
}
