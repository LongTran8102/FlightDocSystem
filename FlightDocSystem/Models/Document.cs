using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlightDocSystem.Models
{
    [Table("Documents")]
    public class Document
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string DocName { get; set; }
        [Required]
        public int Version { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public DateTime DepartureDate { get; set; }
        public string FlightNO { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Creator { get; set; }
        public string Note { get; set; }

    }
}
