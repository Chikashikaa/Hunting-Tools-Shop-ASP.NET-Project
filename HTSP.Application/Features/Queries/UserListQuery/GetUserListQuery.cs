using MediatR;
using System;

namespace HTSP.Application.Features.Queries.UserListQuery
{
    public class GetUserListQuery : IRequest<UserListVm>
    {
        public Guid UserID { get; set; }
    }
}
