using AutoMapper;

namespace Xamarin.Models.ViewModels.AppModule
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.AppModule, IndexViewModel>();
            CreateMap<Models.AppModule, CreateViewModel>().ReverseMap();
            CreateMap<Models.AppModule, EditViewModel>().ReverseMap();
        }
    }
}
