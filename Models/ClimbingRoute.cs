using System.ComponentModel.DataAnnotations;

namespace Backcrazyhorse.Models
{
    public class ClimbingRoute 
    {
        public int ClimbingRouteId { get; set; }
        public required string Name { get; set; }
        public string? Describe { get; set; }
        public List<Image>? Images { get; set; }
        public string? Category { get; set; } // категория сложности
        public string? Testimonial { get; set; } // высота в метрах, другие св-ва
        public int? BoltCount { get; set; } // количество шлямбуров
        
        public int SectorId { get; set; }
        public Sector? Sector  { get; set; }
    }


}