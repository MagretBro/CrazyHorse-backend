using System.ComponentModel.DataAnnotations;

namespace Backcrazyhorse.Models
{
    public class ClimbingRoute 
    {
        public int ClimbingRouteId { get; set; }
        public required string Name { get; set; }
        public required string Describe { get; set; }
        public List<Image> Images { get; set; } = new List<Image>();



        public required string Grade { get; set; } // категория сложности
        public double Height { get; set; } // высота в метрах
        public int BoltCount { get; set; } // количество шлямбуров
        
        public int SectorId { get; set; }
        public required Sector Sector  { get; set; }
    }


}