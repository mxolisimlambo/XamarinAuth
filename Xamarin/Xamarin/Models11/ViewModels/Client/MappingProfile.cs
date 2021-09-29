using AutoMapper;

namespace Xamarin.ViewModels.Client
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.Client, IndexViewModel>();
            CreateMap<Models.Client, EditViewModel>().ReverseMap();
            CreateMap<Models.Client, CreateViewModel>().ReverseMap();
        }
    }
}
