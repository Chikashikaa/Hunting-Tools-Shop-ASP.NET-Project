using MediatR;
using System;

namespace HTSP.Application.Features.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<Guid>
    {
        public Guid UserID { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhoneNumber { get; set; }
        public Guid AccountID { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
    }
}