﻿
namespace EventPlanner.Dtos.UserDtos
{
    public class UserEventsDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
    }
}
