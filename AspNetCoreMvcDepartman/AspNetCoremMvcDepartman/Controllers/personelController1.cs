using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoremMvcDepartman.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoremMvcDepartman.Controllers
{
    public class personelController1 : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Personels.ToList();
            return View(degerler);
        }
    }
}
