using AutoMapper;

namespace Xamarin.ViewModels.CityTown
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.CityTown, IndexViewModel>();
            CreateMap<Models.CityTown, EditViewModel>().ReverseMap();
            CreateMap<Models.CityTown, CreateViewModel>().ReverseMap();
        }
    }
}
