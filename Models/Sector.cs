using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backcrazyhorse.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Backcrazyhorse.Models
{

    public class Sector {
        public required int SectorId { get; set; }
        public required string Name { get; set; }
        public required string Describe { get; set; }
        public int MassiveId  { get; set; }
        public required Massive Massive { get; set; }
        public required ICollection<ClimbingRoute> ClimbingRoutes  { get; set; }

    }
}