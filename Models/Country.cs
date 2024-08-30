using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backcrazyhorse.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Backcrazyhorse.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public required string Name { get; set; }
        public required ICollection<Region> Regions { get; set; }   
    }

}