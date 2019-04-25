using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SuperHero.Models;

namespace SuperHero.Controllers
{
    public class HeroController : Controller
    {

        public ApplicationDbContext Db { get; set; }
        // GET: HERO

        public HeroController(ApplicationDbContext db)
        {
          Db = db;
        }

        public ActionResult Index()
        {
            return View();
        }

        // GET: HERO/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HERO/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HERO/Create
        [HttpPost]
        public ActionResult Create(Hero hero)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Db.Heros.Add(hero);
                    Db.SaveChanges();

                    // TODO: Add insert logic here

                    return RedirectToAction("Index");
                }
                else
                {
                    return View(hero);
                }
            }
            catch
            {
                return View(hero);
            }
        }

        // GET: HERO/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HERO/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Hero hero)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HERO/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HERO/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Hero hero)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
