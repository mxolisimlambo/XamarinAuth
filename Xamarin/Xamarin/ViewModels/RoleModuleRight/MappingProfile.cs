using AutoMapper;

namespace Xamarin.Models.ViewModels.RoleModuleRight
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.RoleModuleRight, IndexViewModel>();
            CreateMap<Models.RoleModuleRight, EditViewModel>().ReverseMap();
            CreateMap<Models.RoleModuleRight, CreateViewModel>().ReverseMap();
        }
    }
}
