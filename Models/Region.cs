using System.ComponentModel.DataAnnotations;

namespace Backcrazyhorse.Models
{
 
 public class Region 
    {
        public required int RegionId { get; set; }
        public required string Name { get; set; }
        public List<string>? Images { get; set; } 
        public int? CountryId { get; set; }
        public Country? Country { get; set; }
        public ICollection<Massive>? Massives {get; set; }
    }
}