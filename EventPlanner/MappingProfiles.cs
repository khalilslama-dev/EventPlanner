using AutoMapper;
using EventPlanner.Dtos;
using EventPlanner.Dtos.UserDtos;
using EventPlanner.Models;

namespace EventPlanner
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() { 
            CreateMap<Event,EventDto>().ReverseMap();
            CreateMap<Event, UserEventsDto>();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<List<User>, List<UserDto>>().ReverseMap();
            this.AllowNullCollections = true;
            this.AddGlobalIgnore("Item");
        }
        
    }
}
