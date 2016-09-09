using DevTest.Db;
using DevTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new Character();

            using (var ctx = new DevTestContext())
            {
                if (ctx.Characters.Any())
                {                    
                    model = ctx.Characters.OrderByDescending(x => x.DateAdded).First();
                    ViewBag.Title = model.Name;

                }
                else
                {
                    ViewBag.Title = "No Characters";
                }
            }

            //We could display the data using ViewBag but I prefer using a strongly-typed model.
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.Title = "Create Characters";

            //Sample Character
            var model = new Character()
            {
                Name = "Lone Wanderer",                
                Gender = "Male",
                Race = "Human",
                ManaPoints = 8,
                HitPoints = 30,
                Strength = 3,
                Stamina = 8,                
                Intellect = 5,
                Agility = 4,
                DateAdded = DateTime.Now
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(Character model)
        {
            if (ModelState.IsValid)
            {
                using (var ctx = new DevTestContext())
                {
                    model.CharacterId = Guid.NewGuid();
                    model.DateAdded = DateTime.Now;

                    ctx.Characters.Add(model);
                    ctx.SaveChanges();
                }
                
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public ActionResult Chat()
        {
            return View();
        }

    }
}
