using AutoMapper;

namespace Xamarin.Models.ViewModels.Region
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.Region, IndexViewModel>();
            CreateMap<Models.Region, EditViewModel>().ReverseMap();
            CreateMap<Models.Region, CreateViewModel>().ReverseMap();
        }
    }
}
