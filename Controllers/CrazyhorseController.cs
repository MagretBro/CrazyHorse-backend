using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace backcrazyhorse.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    // api/crazyhorses
    public class CrazyhorsesController:ControllerBase
    {
        [HttpGet]
        public string SayHi()
        {
            return "Hi";
        }
    }
}