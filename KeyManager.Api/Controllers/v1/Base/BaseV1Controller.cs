using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace KeyManager.Api.Controllers.v1.Base
{
    public abstract class BaseV1Controller : Controller
    {
        [Produces("application/json")]
        [ApiVersion("1.0")]
        [Route("api/[controller]")]
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}