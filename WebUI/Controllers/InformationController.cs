using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace WebUI.Controllers
{
    [AllowAnonymous]
    public class InformationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}