using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootstrapKnockout.Services;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapKnockout.Controllers
{
    [Route("api/pets")]
    public class PetsController : Controller
    {
        private readonly IDataService _dataService;

        public PetsController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dataService.GetPets());
        }
    }
}
