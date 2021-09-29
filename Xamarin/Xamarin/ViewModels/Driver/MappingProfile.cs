using AutoMapper;

namespace Xamarin.Models.ViewModels.Driver
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.Driver, IndexViewModel>();
            CreateMap<Models.Driver, EditViewModel>().ReverseMap();
            CreateMap<Models.Driver, CreateViewModel>().ReverseMap();
        }
    }
}
