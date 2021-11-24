using AutoMapper;
using HTSP.Application.Features.Commands.CreateUser;
using HTSP.Application.Mapping;
using System;

namespace HTSP.WebAPI.Models
{
    public class CreateUserDto : IMapWith<CreateUserCommand>
    {
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhoneNumber { get; set; }
        public Guid AccountID { get; set; }
        public string AccountLogin { get; set; }
        public string AccountPassWord { get; set; }
        public void Mapping(Profile UserProfile)
        {
            UserProfile.CreateMap<CreateUserDto, CreateUserCommand>()
                .ForMember(UserVm => UserVm.UserName, opt => opt.MapFrom(user => user.UserName))
                .ForMember(UserVm => UserVm.UserLastName, opt => opt.MapFrom(user => user.UserLastName))
                .ForMember(UserVm => UserVm.UserEmail, opt => opt.MapFrom(user => user.UserEmail))
                .ForMember(UserVm => UserVm.UserPhoneNumber, opt => opt.MapFrom(user => user.UserPhoneNumber))
                .ForMember(AccountVm => AccountVm.UserLogin, opt => opt.MapFrom(account => account.AccountLogin))
                .ForMember(AccountVm => AccountVm.UserPassword, opt => opt.MapFrom(account => account.AccountPassWord))
                .ForMember(AccountVm => AccountVm.AccountID, opt => opt.MapFrom(account => account.AccountID));
        }
    }
}
