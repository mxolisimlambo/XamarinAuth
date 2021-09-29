using AutoMapper;

namespace Xamarin.Models.ViewModels.Shift
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.Shift, IndexViewModel>();
            CreateMap<Models.Shift, EditViewModel>().ReverseMap();
            CreateMap<Models.Shift, CreateViewModel>().ReverseMap();
        }
    }
}
