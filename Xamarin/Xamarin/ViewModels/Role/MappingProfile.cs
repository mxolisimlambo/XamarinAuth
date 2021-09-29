using AutoMapper;
using Xamarin.Base;

namespace Xamarin.ViewModels.Role
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.AppRole, IndexViewModel>().ForMember(s=>s.DateLastEdited, m=>m.Ignore());
            CreateMap<Models.AppRole, EditViewModel>().ReverseMap();
            CreateMap<Models.AppRole, CreateViewModel>().ReverseMap();
        }
    }
}
