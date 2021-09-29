using AutoMapper;

namespace Xamarin.Models.ViewModels.UserSectionRight
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.UserSectionRight, IndexViewModel>();
            CreateMap<Models.UserSectionRight, EditViewModel>().ReverseMap();
            CreateMap<Models.UserSectionRight, CreateViewModel>().ReverseMap();
        }
    }
}
