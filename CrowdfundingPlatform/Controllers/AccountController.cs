using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundingPlatform.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult ForgotPassword() => View();

        [HttpGet]
        public IActionResult Registration() => View();

        [HttpGet]
        public IActionResult Login() => View();
    }
}
