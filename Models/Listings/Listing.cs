using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections.Generic;
using propertyapi.Models.Locations;
using propertyapi.Models.Agents;
namespace propertyapi.Models.Listings
{
    public class Listing
    {
        public int Id { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int NumberOfBedroom { get; set; }
        [Required]
        public string OwnRefNumber { get; set; }
        [Required]
        public string MarkettingHeading { get; set; }
        [Required]
        public string Description { get; set; }

        [Required]
        public int SurburbId { get; set; }
        public Surburb Surburb { get; set; }
        [Required]
        public int AgentId { get; set; }
        public Agent Agent { get; set; }


    }
    

}