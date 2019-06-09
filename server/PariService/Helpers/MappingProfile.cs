using AutoMapper;
using PariService.Database;
using PariService.Dto;

namespace PariService.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Paris, PariItem>();
            CreateMap<AttitudeItem, Attitudes>();
        }
    }
}