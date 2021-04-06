using AutoMapper;
using EFCDomain.Models;
using EFCWebAPI.ViewModels;

namespace EFCWebAPI.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CustomerViewModel, Customer>();
        }
    }
}