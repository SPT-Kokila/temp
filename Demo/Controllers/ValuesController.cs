using Demo.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Controllers
{
    [Route("")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpPost]
        [Route("add")]
        public IActionResult Add(Model.Job value) 
        {
            return Ok(new NewDemo().Add(value));
        }
    }
}
