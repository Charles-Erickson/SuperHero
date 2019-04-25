using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHero.Controllers
{
    public class HEROController : Controller
    {
        // GET: HERO
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
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HERO/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HERO/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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
        public ActionResult Delete(int id, FormCollection collection)
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
