using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FlightDocSystem.Models
{
    public class FlightDocSystemDBContext:DbContext
    {
        public FlightDocSystemDBContext() : base("name=DefaultConnection") { }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Document> Documents { get; set; }
    }
}