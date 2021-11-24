using AutoMapper;
using HTSP.Application.Mapping;
using HTSP.Domain.Entities;
using System;

namespace HTSP.Application.Features.Queries.AccountQuery
{
    public class AccountVm : IMapWith<Account>
    {
        public Guid AccountID { get; set; }
        public string AccountLogin { get; set; }
        public string AccountPassWord { get; set; }
        public void Mapping(Profile AccountProfile)
        {
            AccountProfile.CreateMap<Account, AccountVm>()
                .ForMember(AccountVm => AccountVm.AccountLogin, opt => opt.MapFrom(account => account.AccountLogin))
                .ForMember(AccountVm => AccountVm.AccountPassWord, opt => opt.MapFrom(account => account.AccountPassWord))
                .ForMember(AccountVm => AccountVm.AccountID, opt => opt.MapFrom(account => account.AccountID));
        }
    }
}
