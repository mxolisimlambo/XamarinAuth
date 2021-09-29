using AutoMapper;

namespace Xamarin.ViewModels.AppSection
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.AppSection, IndexViewModel>();
            CreateMap<Models.AppSection, EditViewModel>().ReverseMap();
            CreateMap<Models.AppSection, CreateViewModel>().ReverseMap();
        }
    }
}
