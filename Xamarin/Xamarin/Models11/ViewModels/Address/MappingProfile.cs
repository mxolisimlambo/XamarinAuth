using AutoMapper;

namespace Xamarin.Models.ViewModels.Address
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.Address, IndexViewModel>();
            CreateMap<Models.Address, EditViewModel>().ReverseMap();
            CreateMap<Models.Address, CreateViewModel>().ReverseMap();
        }
    }
}
