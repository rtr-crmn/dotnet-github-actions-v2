using System;

using Microsoft.AspNetCore.Mvc;

using ServiceA.Application;

namespace ServiceA.Controllers
{
    [Route("api/[controller]")]
    public class VersionController : Controller
    {
        
        public IActionResult Get()
        {
            return new OkObjectResult(VersionRegistry.Value);
        }

    }
}
