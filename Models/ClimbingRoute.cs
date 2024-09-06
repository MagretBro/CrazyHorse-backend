using System.ComponentModel.DataAnnotations;

namespace Backcrazyhorse.Models
{
    public class ClimbingRoute 
    {
        public int ClimbingRouteId { get; set; }
        public required string Name { get; set; }
        public required string Describe { get; set; }
        public List<Image> Images { get; set; } = new List<Image>();
        public required string Category { get; set; } // категория сложности
        public double Testimonial { get; set; } // высота в метрах, другие св-ва
        public int BoltCount? { get; set; } // количество шлямбуров
        
        public int SectorId { get; set; }
        public Sector? Sector  { get; set; }
    }


}