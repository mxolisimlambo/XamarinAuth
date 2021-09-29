using AutoMapper;

namespace Xamarin.Models.ViewModels.CityTown
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
