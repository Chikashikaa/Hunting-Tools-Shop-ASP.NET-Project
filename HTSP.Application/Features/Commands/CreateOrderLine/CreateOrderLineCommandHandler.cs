using HTSP.Application.Interfaces;
using HTSP.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace HTSP.Application.Features.Commands.CreateOrderLine
{
    public class CreateOrderLineCommandHandler
        : IRequestHandler<CreateOrderLineCommand, Guid>
    {
        private readonly IHTSPDbContext _dbContext;
        public CreateOrderLineCommandHandler(IHTSPDbContext dbContext) =>
            _dbContext = dbContext;
        public async Task<Guid> Handle(CreateOrderLineCommand LineRequest, CancellationToken cancellationToken)
        {
            var line = new OrderLine
            {
                OrderLineID = Guid.NewGuid(),
                ArticleNumber = LineRequest.ArticleNumber,
                OrderID = LineRequest.OrderID
            };
            await _dbContext.OrderLines.AddAsync(line, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return line.OrderLineID;
        }
    }
}
