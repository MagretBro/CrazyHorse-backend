using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backcrazyhorse.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Backcrazyhorse.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public string? Path { get; set; } // Путь к изображению в папке
        public int? ClimbingRouteId { get; set; }
        public ClimbingRoute? ClimbingRoute { get; set; }
        public int? SectorId { get; set; }
        public Sector? Sector { get; set; }
    }
}