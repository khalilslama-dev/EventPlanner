﻿using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using EventPlanner.Models;

namespace EventPlanner.Dtos.UserDtos
{
    public class UserDto
    {
        [Required]
        public long Id { get; set; }
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }
        public ICollection<UserEventsDto> Events { get; set; }
    }
}
