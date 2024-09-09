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
        public string? Describe { get; set; }
        public int MassiveId  { get; set; }
        public Massive? Massive { get; set; }
        public ICollection<ClimbingRoute>? ClimbingRoutes  { get; set; }
        public ICollection<Image>? Images { get; set; } = new List<Image>();


    }
}