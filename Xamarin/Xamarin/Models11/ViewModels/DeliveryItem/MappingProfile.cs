using AutoMapper;

namespace Xamarin.ViewModels.DeliveryItem
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.DeliveryItem, IndexViewModel>();
            CreateMap<Models.DeliveryItem, EditViewModel>().ReverseMap();
            CreateMap<Models.DeliveryItem, CreateViewModel>().ReverseMap();
        }
    }
}
