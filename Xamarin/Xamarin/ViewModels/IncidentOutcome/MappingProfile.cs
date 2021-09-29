using AutoMapper;

namespace Xamarin.Models.ViewModels.IncidentOutcome
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.IncidentOutcome, IndexViewModel>();
            CreateMap<Models.IncidentOutcome, EditViewModel>().ReverseMap();
            CreateMap<Models.IncidentOutcome, CreateViewModel>().ReverseMap();
        }
    }
}
