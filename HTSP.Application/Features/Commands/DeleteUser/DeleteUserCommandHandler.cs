using HTSP.Application.Features.Exceptions;
using HTSP.Application.Interfaces;
using HTSP.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace HTSP.Application.Features.Commands.DeleteUser
{
    public class DeleteUserCommandHandler
    : IRequestHandler<DeleteUserCommand>
    {
        private readonly IHTSPDbContext _dbContext;
        public DeleteUserCommandHandler(IHTSPDbContext dbContext) =>
            _dbContext = dbContext;
        public async Task<Unit> Handle(DeleteUserCommand DeleteRequest, CancellationToken cancellationToken)
        {
            var user =
                await _dbContext.Users.FindAsync(new object[] { DeleteRequest.UserID }, cancellationToken);
            var account =
                 await _dbContext.Accounts.FindAsync(new object[] { DeleteRequest.AccountID }, cancellationToken);
            if (user == null || user.UserID != DeleteRequest.UserID)
            {
                throw new NotFoundException(nameof(User), DeleteRequest.UserID);
            }
            if (account == null || account.AccountID != DeleteRequest.AccountID)
            {
                throw new NotFoundException(nameof(Account), DeleteRequest.AccountID);
            }

            _dbContext.Users.Remove(user);
            _dbContext.Accounts.Remove(account);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
