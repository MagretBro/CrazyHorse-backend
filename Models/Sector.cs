using System.ComponentModel.DataAnnotations;

namespace Backcrazyhorse.Models
{

    public class Sector {
        public required int SectorId { get; set; }
        public required string Name { get; set; }
        public required string Describe { get; set; }
        public int MassiveId  { get; set; }
        public required Massive Massive { get; set; }
        public required ICollection<ClimbingRoute> ClimbingRoute  { get; set; }

    }
}