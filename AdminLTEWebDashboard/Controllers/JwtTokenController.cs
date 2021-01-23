using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTEWebDashboard.Controllers
{
    public class JwtTokenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateJwt()
        {
            return View();
        }

        public IActionResult RefreshToken()
        {
            return View();
        }
    }
}
