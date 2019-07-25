using System.ComponentModel.DataAnnotations;

namespace BeehiveGPS_API.Models
{
    public class Position
    {
        [Key]
        public int Id { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}