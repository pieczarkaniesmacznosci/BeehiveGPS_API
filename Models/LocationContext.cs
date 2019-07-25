using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeehiveGPS_API.Models
{
    public class LocationContext: DbContext
    {
        public DbSet<Location> Locations { get; set; }
        public DbSet<Device> Devices { get; set; }

        public LocationContext(DbContextOptions<LocationContext> options)
            : base(options)
        {
        }
    }
}
