using AutoMapper;

namespace Xamarin.Models.ViewModels.TripIncident
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.TripIncident, IndexViewModel>();
            CreateMap<Models.TripIncident, EditViewModel>().ReverseMap();
            CreateMap<Models.TripIncident, CreateViewModel>().ReverseMap();
        }
    }
}
