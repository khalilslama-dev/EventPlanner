using AutoMapper;
using EventPlanner.Models;

namespace EventPlanner
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() { 
            CreateMap<Event,EventDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
