using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeehiveGPS_API.Models
{
    public class Location
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public Position Position { get; set; }
        public DateTime Time { get; set; }
    }
}
