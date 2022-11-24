using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlightDocSystem.Models
{
    [Table ("Flights")]
    public class Flight
    {
        internal static IEnumerable<object> flights;

        [Key]
        public int Id { get; set; }
        [Required]
        public string FlightNO { get; set; }
        [Required]
        public string From { get; set; }
        [Required]
        public string To { get; set; }
        [Required]
        public DateTime DepartureDate { get; set; }
        [Required]
        public int TotalDoc { get; set; }
 
    }
}