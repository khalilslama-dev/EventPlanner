﻿using System.ComponentModel.DataAnnotations;

namespace EventPlanner.Models
{
    public class Address
    {
        [Key]
        public long Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
