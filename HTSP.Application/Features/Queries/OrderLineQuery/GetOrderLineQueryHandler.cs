using AutoMapper;
using HTSP.Application.Features.Exceptions;
using HTSP.Application.Interfaces;
using HTSP.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace HTSP.Application.Features.Queries.OrderLineQuery
{
    class GetOrderLineQueryHandler
    : IRequestHandler<GetOrderLineQuery, OrderLineVm>
    {
        private readonly IHTSPDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetOrderLineQueryHandler(IHTSPDbContext dbContext, IMapper mapper) =>
            (_dbContext, _mapper) = (dbContext, mapper);
        public async Task<OrderLineVm> Handle(GetOrderLineQuery GetRequest, CancellationToken cancellationToken)
        {
            var orderline = await _dbContext.OrderLines
                .FirstOrDefaultAsync(orderline => orderline.OrderLineID == GetRequest.OrderLineID, cancellationToken);
            if (orderline == null || orderline.OrderLineID != GetRequest.OrderLineID)
            {
                throw new NotFoundException(nameof(OrderLine), GetRequest.OrderLineID);
            }
            return _mapper.Map<OrderLineVm>(orderline);
        }
    }
}
