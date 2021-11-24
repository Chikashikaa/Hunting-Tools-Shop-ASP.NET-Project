using MediatR;
using System;

namespace HTSP.Application.Features.Queries.UserQuery
{
    public class GetUserQuery : IRequest<UserVm>
    {
        public Guid UserID { get; set; }
    }
}
