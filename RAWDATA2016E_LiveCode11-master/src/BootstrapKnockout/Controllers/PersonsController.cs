using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootstrapKnockout.Services;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapKnockout.Controllers
{
    [Route("api/persons")]
    public class PersonsController : Controller
    {
        private readonly IDataService _dataService;

        public PersonsController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dataService.GetPersons());
        }
    }
}
