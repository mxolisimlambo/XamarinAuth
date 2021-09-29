
using AutoMapper;

namespace Xamarin.Models.ViewModels.EndPoint
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.EndPoint, IndexViewModel>();
            CreateMap<Models.EndPoint, EditViewModel>().ReverseMap();
            CreateMap<Models.EndPoint, CreateViewModel>().ReverseMap();
        }
    }
}
