using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A2U2_PW.Models;
using Microsoft.AspNetCore.Mvc;

namespace A2U2_PW.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            mexicoContext context = new mexicoContext();
            var estados = context.Estados.OrderBy(x => x.Nombre).ToList();
            return View(estados);
        }
    }
}
