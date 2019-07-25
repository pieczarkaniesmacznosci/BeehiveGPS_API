using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeehiveGPS_API.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public Device Device { get; set; }
        public Position Position { get; set; }
        public DateTime Time { get; set; }
    }
}
