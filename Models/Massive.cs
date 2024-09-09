using System.ComponentModel.DataAnnotations;

namespace Backcrazyhorse.Models
{

    public class Massive {
        public int MassiveId { get; set; }
        public required string Name { get; set; }
        public List<string>? Images { get; set; } 
        public string? Describe { get; set; }
        public int? RegionId { get; set; }
        public Region? Region { get; set; }
        public ICollection<Sector>? Sectors { get; set; }
    }

}