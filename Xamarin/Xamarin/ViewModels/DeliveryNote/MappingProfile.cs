using AutoMapper;

namespace Xamarin.Models.ViewModels.DeliveryNote
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.DeliveryNote, IndexViewModel>();
            CreateMap<Models.DeliveryNote, EditViewModel>().ReverseMap();
            CreateMap<Models.DeliveryNote, CreateViewModel>().ReverseMap();
        }
    }
}
