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

        public HeroController()
        {
            Db = new ApplicationDbContext();
        }

        //public HeroController(ApplicationDbContext db)
        //{
        //  Db = db;
        //}

        public ActionResult Index()
        {
            return View(Db.Heros.ToList());
        }

        // GET: HERO/Details/5
        public ActionResult Details(int id)
        {
            Hero hero = Db.Heros.Find(id);
            return View(hero);
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
            var hero = Db.Heros.Find(id);
            return View(hero);
        }

        // POST: HERO/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Hero hero)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var heroFromDb = Db.Heros.Find(id);
                    heroFromDb.HeroName = hero.HeroName;
                    heroFromDb.SuperPower = hero.SuperPower;
                    heroFromDb.SecondaryPower = hero.SecondaryPower;
                    heroFromDb.AlterEgo = hero.AlterEgo;
                    heroFromDb.Catchphrase = hero.Catchphrase;
                    Db.SaveChanges();
                }
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
            var hero = Db.Heros.Find(id);
            return View(hero);
        }

        // POST: HERO/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Hero hero)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var heroToRemove = Db.Heros.Find(id);
                    Db.Heros.Remove(heroToRemove);
                    Db.SaveChanges();
                }
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
