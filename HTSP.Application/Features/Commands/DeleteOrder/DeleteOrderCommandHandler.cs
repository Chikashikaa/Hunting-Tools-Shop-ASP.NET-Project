using HTSP.Application.Features.Exceptions;
using HTSP.Application.Interfaces;
using HTSP.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace HTSP.Application.Features.Commands.DeleteOrder
{
    public class DeleteOrderCommandHandler
    : IRequestHandler<DeleteOrderCommand>
    {
        private readonly IHTSPDbContext _dbContext;
        public DeleteOrderCommandHandler(IHTSPDbContext dbContext) =>
            _dbContext = dbContext;
        public async Task<Unit> Handle(DeleteOrderCommand DeleteRequest, CancellationToken cancellationToken)
        {
            var order = await _dbContext.Orders.FindAsync(new object[] { DeleteRequest.OrderID }, cancellationToken);
            if (order == null || order.OrderId != DeleteRequest.OrderID)
            {
                throw new NotFoundException(nameof(Order), DeleteRequest.OrderID);
            }
            _dbContext.Orders.Remove(order);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
