using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoremMvcDepartman.Models; //context sınıfına ulaşıp veritabınına ulaşabilmek için

namespace AspNetCoremMvcDepartman.Controllers
{

    
    public class DepartController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Departmans.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult YeniDepartman()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniDepartman(Departman d) // departman sınıfından d parametresi kullanır
        {
            c.Departmans.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DepartmanSil(int id)
        {
            var dep = c.Departmans.Find(id);
            c.Departmans.Remove(dep);
            c.SaveChanges();

            return RedirectToAction("Index");

        }


        public IActionResult DepartmanGetir(int id)
        {
            var depart = c.Departmans.Find(id);

            return View("DepartmanGetir", depart); //açılan departgetir sayfasında textbox da departmanın adı yazsın diye, id zaten yazıyor çünkü parametre olarak gönderdik.
        }

        public IActionResult DepartmanGuncelle(Departman d)
        {
            var dep = c.Departmans.Find(d.ID);
            dep.DepartmanAd = d.DepartmanAd;
            c.SaveChanges();

            return RedirectToAction("Index");
            
        }
    }
}
