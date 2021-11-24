using MediatR;
using System;

namespace HTSP.Application.Features.Commands.DeleteUser
{
    public class DeleteUserCommand : IRequest
    {
        public Guid UserID { get; set; }
        public Guid AccountID { get; set; }
    }
}
