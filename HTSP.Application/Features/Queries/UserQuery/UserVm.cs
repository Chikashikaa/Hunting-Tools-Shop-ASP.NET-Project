using AutoMapper;
using HTSP.Application.Mapping;
using HTSP.Domain.Entities;
using System;

namespace HTSP.Application.Features.Queries.UserQuery
{
    public class UserVm : IMapWith<User>
    {
        public Guid UserID { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhoneNumber { get; set; }
        public void Mapping(Profile UserProfile)
        {
            UserProfile.CreateMap<User, UserVm>()
                .ForMember(UserVm => UserVm.UserName, opt => opt.MapFrom(user => user.UserName))
                .ForMember(UserVm => UserVm.UserLastName, opt => opt.MapFrom(user => user.UserLastName))
                .ForMember(UserVm => UserVm.UserEmail, opt => opt.MapFrom(user => user.UserEmail))
                .ForMember(UserVm => UserVm.UserPhoneNumber, opt => opt.MapFrom(user => user.UserPhoneNumber))
                .ForMember(UserVm => UserVm.UserID, opt => opt.MapFrom(user => user.UserID));

        }
    }
}
