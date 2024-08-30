using System.ComponentModel.DataAnnotations;

namespace Backcrazyhorse.Models
{
 
 public class Region 
    {
        public required int RegionId { get; set; }
        public required string Name { get; set; }
        public required List<string> Images { get; set; } 
        public int CountryId { get; set; }
        public required Country Country { get; set; }
        public required ICollection<Massive> Massives {get; set; }
    }
}