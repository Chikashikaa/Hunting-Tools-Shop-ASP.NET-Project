using AutoMapper;
using HTSP.Application.Features.Exceptions;
using HTSP.Application.Interfaces;
using HTSP.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace HTSP.Application.Features.Queries.OrderQuery
{
    public class GetOrderQueryHandler
    : IRequestHandler<GetOrderQuery, OrderVm>
    {
        private readonly IHTSPDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetOrderQueryHandler(IHTSPDbContext dbContext, IMapper mapper) =>
            (_dbContext, _mapper) = (dbContext, mapper);
        public async Task<OrderVm> Handle(GetOrderQuery GetRequest, CancellationToken cancellationToken)
        {
            var order = await _dbContext.Orders
                .FirstOrDefaultAsync(order => order.OrderId == GetRequest.OrderID, cancellationToken);
            if (order == null || order.OrderId != GetRequest.OrderID)
            {
                throw new NotFoundException(nameof(Order), GetRequest.OrderID);
            }
            return _mapper.Map<OrderVm>(order);
        }
    }
}
