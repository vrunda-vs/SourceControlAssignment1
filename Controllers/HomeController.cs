﻿using SourceControlAss.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SourceControlAss.Controllers
{
    public class HomeController : Controller
    {
        private gatewayEntities1 db = new gatewayEntities1();
        // GET: Home
        public ActionResult Index()
        {
            return View(db.students.ToList());
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(student s)
        {
            try
            {
                // TODO: Add insert logic here

                if(ModelState.IsValid)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
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

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
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
