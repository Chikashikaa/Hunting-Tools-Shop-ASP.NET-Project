using AutoMapper;
using HTSP.Application.Mapping;
using HTSP.Domain.Entities;
using System;

namespace HTSP.Application.Features.Queries.AccountListQuery
{
    public class AccountListLookupDto : IMapWith<Account>
    {
        public Guid AccountID { get; set; }
        public string Login { get; set; }
        public void Mapping(Profile AccountProfile)
        {
            AccountProfile.CreateMap<Account, AccountListLookupDto>()
                .ForMember(AccountVm => AccountVm.AccountID, opt => opt.MapFrom(account => account.AccountID))
                .ForMember(AccountVm => AccountVm.Login, opt => opt.MapFrom(account => account.AccountLogin));
        }
    }
}
