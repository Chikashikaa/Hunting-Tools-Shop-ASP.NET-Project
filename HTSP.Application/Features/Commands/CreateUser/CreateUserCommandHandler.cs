using HTSP.Application.Interfaces;
using HTSP.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace HTSP.Application.Features.Commands.CreateUser
{
    public class CreateUserCommandHandler
        : IRequestHandler<CreateUserCommand, Guid>
    {
        private readonly IHTSPDbContext _dbContext;
        public CreateUserCommandHandler(IHTSPDbContext dbContext) =>
            _dbContext = dbContext;
        public async Task<Guid> Handle(CreateUserCommand UserRequest, CancellationToken cancellationToken)
        {
            var user = new User
            {
                UserID = Guid.NewGuid(),
                UserName = UserRequest.UserName,
                UserLastName = UserRequest.UserLastName,
                UserEmail = UserRequest.UserEmail,
                UserPhoneNumber = UserRequest.UserPhoneNumber
            };
            var account = new Account
            {
                AccountID = Guid.NewGuid(),
                AccountLogin = UserRequest.UserLogin,
                AccountPassWord = UserRequest.UserPassword,
            };

            await _dbContext.Accounts.AddAsync(account, cancellationToken);
            await _dbContext.Users.AddAsync(user, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return account.AccountID;
        }
    }
}
