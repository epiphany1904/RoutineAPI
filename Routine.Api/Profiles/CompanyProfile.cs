using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Routine.Api.Entities;
using Routine.Api.Models;

namespace Routine.Api.Profiles
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            //创建映射
            CreateMap<Company, CompanyDto>().ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Name));
            CreateMap<CompanyAddDto, Company>();
            CreateMap<Company, CompanyFullDto>();
            CreateMap<CompanyAddWithBankruptTimeDto, Company>();
        }
    }
}
