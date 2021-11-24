using AutoMapper;
using HTSP.Application.Mapping;
using HTSP.Domain.Entities;
using System;

namespace HTSP.Application.Features.Queries.UserListQuery
{
    public class UserListLookupDto : IMapWith<User>
    {
        public Guid UserID { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public void Mapping(Profile UserProfile)
        {
            UserProfile.CreateMap<User, UserListLookupDto>()
                .ForMember(UserVm => UserVm.UserName, opt => opt.MapFrom(user => user.UserName))
                .ForMember(UserVm => UserVm.UserLastName, opt => opt.MapFrom(user => user.UserLastName))
                .ForMember(UserVm => UserVm.UserID, opt => opt.MapFrom(user => user.UserID));
        }
    }
}
