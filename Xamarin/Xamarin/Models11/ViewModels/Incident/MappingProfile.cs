
using AutoMapper;

namespace Xamarin.Models.ViewModels.Incident
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.Incident, IndexViewModel>();
            CreateMap<Models.Incident, DetailViewModel>();
            CreateMap<Models.Incident, EditViewModel>().ReverseMap();
            CreateMap<Models.Incident, CreateViewModel>().ReverseMap();
        }
    }
}
