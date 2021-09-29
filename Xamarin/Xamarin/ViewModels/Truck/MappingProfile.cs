using AutoMapper;

namespace Xamarin.Models.ViewModels.Truck
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.Truck, IndexViewModel>();
            CreateMap<Models.Truck, EditViewModel>().ReverseMap();
            CreateMap<Models.Truck, CreateViewModel>().ReverseMap();
        }
    }
}
