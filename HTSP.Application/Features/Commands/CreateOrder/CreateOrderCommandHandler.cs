using HTSP.Application.Interfaces;
using HTSP.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace HTSP.Application.Features.Commands.CreateOrder
{
    class CreateOrderCommandHandler
    : IRequestHandler<CreateOrderCommand, Guid>
    {
        private readonly IHTSPDbContext _dbContext;
        public CreateOrderCommandHandler(IHTSPDbContext dbContext) =>
            _dbContext = dbContext;
        public async Task<Guid> Handle(CreateOrderCommand OrderRequest, CancellationToken cancellationToken)
        {
            var order = new Order
            {
                OrderId = Guid.NewGuid(),
                OrderGetDate = DateTime.Now,
                OrderSetDate = DateTime.Now.AddDays(3),
                OrderStatus = false
            };
            await _dbContext.Orders.AddAsync(order, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return order.OrderId;
        }
    }
}
