using AutoMapper;
using EFCDomain.Models;
using EFCWebAPI.ViewModels;

namespace EFCWebAPI.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Customer, CustomerViewModel>();
        }
    }
}