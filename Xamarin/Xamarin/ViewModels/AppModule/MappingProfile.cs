using AutoMapper;

namespace Xamarin.ViewModels.AppModule
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
