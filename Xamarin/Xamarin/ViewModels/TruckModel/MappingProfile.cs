using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models.ViewModels.TruckModel
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.TruckModel, IndexViewModel>().ForMember(x => x.NumberOfTrucks, m => m.MapFrom(s => s.Trucks.Count()));
            CreateMap<Models.TruckModel, EditViewModel>().ReverseMap();
            CreateMap<Models.TruckModel, CreateViewModel>().ReverseMap();
        }
    }
}
