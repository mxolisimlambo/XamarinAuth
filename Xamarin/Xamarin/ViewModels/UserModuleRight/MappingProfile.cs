using AutoMapper;

namespace Xamarin.Models.ViewModels.UserModuleRight
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.UserModuleRight, IndexViewModel>();
            CreateMap<Models.UserModuleRight, EditViewModel>().ReverseMap();
            CreateMap<Models.UserModuleRight, CreateViewModel>().ReverseMap();
        }
    }
}
