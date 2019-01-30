using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace KeyManager.Api.Controllers.v1
{
    public class UserController : Base.BaseV1Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}