using System.ComponentModel.DataAnnotations;

namespace Backcrazyhorse.Models
{

    public class Massive {
        public int MassiveId { get; set; }
        public required string Name { get; set; }
        public required List<string> Images { get; set; } 
        public required string Describe { get; set; }
        public int RegionId { get; set; }
        public required Region Region { get; set; }
        public required ICollection<Sector> Sectors { get; set; }
    }

}