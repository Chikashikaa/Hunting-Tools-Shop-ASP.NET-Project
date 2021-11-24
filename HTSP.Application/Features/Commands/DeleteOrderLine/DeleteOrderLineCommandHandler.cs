using HTSP.Application.Features.Exceptions;
using HTSP.Application.Interfaces;
using HTSP.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace HTSP.Application.Features.Commands.DeleteOrderLine
{
    public class DeleteOrderLineCommandHandler
    : IRequestHandler<DeleteOrderLineCommand>
    {
        private readonly IHTSPDbContext _dbContext;
        public DeleteOrderLineCommandHandler(IHTSPDbContext dbContext) =>
            _dbContext = dbContext;
        public async Task<Unit> Handle(DeleteOrderLineCommand DeleteRequest, CancellationToken cancellationToken)
        {
            var orderLine =
                await _dbContext.OrderLines.FindAsync(new object[] { DeleteRequest.OrderLineID }, cancellationToken);
            if (orderLine == null || orderLine.OrderLineID != DeleteRequest.OrderLineID)
            {
                throw new NotFoundException(nameof(OrderLine), DeleteRequest.OrderLineID);
            }
            _dbContext.OrderLines.Remove(orderLine);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
