using AutoMapper;

namespace Xamarin.Models.ViewModels.TimeShift
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.TimeShift, IndexViewModel>();
            CreateMap<Models.TimeShift, EditViewModel>().ReverseMap();
            CreateMap<Models.TimeShift, CreateViewModel>().ReverseMap();
        }
    }
}
