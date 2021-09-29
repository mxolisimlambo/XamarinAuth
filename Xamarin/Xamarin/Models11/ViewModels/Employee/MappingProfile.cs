using AutoMapper;

namespace Xamarin.Models.ViewModels.Employee
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.Employee, IndexViewModel>();
            CreateMap<Models.Employee, EditViewModel>().ReverseMap();
            CreateMap<Models.Employee, CreateViewModel>().ReverseMap();
        }
    }
}
