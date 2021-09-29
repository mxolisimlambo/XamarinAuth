using AutoMapper;

namespace Xamarin.ViewModels.Address
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
