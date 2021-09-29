using AutoMapper;

namespace Xamarin.Models.ViewModels.RoleSectionRight
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.RoleSectionRight, IndexViewModel>();
            CreateMap<Models.RoleSectionRight, EditViewModel>().ReverseMap();
            CreateMap<Models.RoleSectionRight, CreateViewModel>().ReverseMap();
        }
    }
}
