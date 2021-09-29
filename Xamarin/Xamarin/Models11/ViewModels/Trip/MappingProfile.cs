using AutoMapper;

namespace Xamarin.Models.ViewModels.Trip
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.Trip, IndexViewModel>();
            CreateMap<Models.Trip, DetailViewModel>();
            CreateMap<Models.Trip, EditViewModel>().ReverseMap();
            CreateMap<Models.Trip, CreateViewModel>().ReverseMap();
        }
    }
}
