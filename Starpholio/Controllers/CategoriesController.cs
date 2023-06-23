/*using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Starpholio.Data;
using Starpholio.Models;
using System.Data.Entity;
using System.Net;
using System.Web;
using System.IO;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.IO;
using System.Globalization;



namespace Starpholio.Controllers
{



    [Authorize(Roles = "administrador")]
    public class CategoriesController : Controller
    {
        public CategoriesController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        private readonly IHttpContextAccessor _httpContextAccessor;
        
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Categories
        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }

        // GET: Categories/Create
        public ActionResult CreateColour()
        {
            _httpContextAccessor.HttpContext.Session.SetInt32("IdPost", -1);
            _httpContextAccessor.HttpContext.Session.SetString("action", "Categories/Create");
            return View();
            //find a way to limit to 1 pick
        }
        public ActionResult CreateStyle()
        {
           
            _httpContextAccessor.HttpContext.Session.SetString("action", "Categories/Create");
            return View();
            //picks are unlimited, think of limiting to maybe 5 bcuz cunts
        }//Create view acomodating for creation of different types, do as landing page
        //need to do joint table for multi categories


        // POST: Categories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateColour([Bind(Include = "ID,Nome")] Categories categories)
        {
            var value = _httpContextAccessor.HttpContext.Session.GetString("action");

            if (value != "Categories/Create")
                return RedirectToAction("Index");
            if (ModelState.IsValid)
            {
                db.Categories.Add(categories);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categories);
        }
        public ActionResult CreateStyle([Bind(Include = "ID,Nome")] Categories categories)
        {
            var value = _httpContextAccessor.HttpContext.Session.GetString("action");

            if (value != "Categories/Create")
                return RedirectToAction("Index");
            if (ModelState.IsValid)
            {
                db.Categories.Add(categories);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categories);
        }
        //MUST CHANGE VIEW TO FIT BOTH AT THE SAME TIME, EQUAL TO LANDING PAGE
        // GET: Categories/Edit/5
        public ActionResult Edit(int id)
        {
            
            Categories categories = db.Categories.Find(id);
            if (categories == null)
            {
                return HttpNotFound();
            }
            _httpContextAccessor.HttpContext.Session.SetInt32("IdPost", id);
            _httpContextAccessor.HttpContext.Session.SetString("action", "Categories/Edit");
            
            return View(categories);
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nome")] Categories categories)
        {

            var action = _httpContextAccessor.HttpContext.Session.GetString("action");
            var idpost = _httpContextAccessor.HttpContext.Session.GetInt32("IdPost");
            if (idpost != categories.ID || action != "Categories/Edit")
                return RedirectToAction("Index");
            if (ModelState.IsValid)
            {
                db.Entry(categories).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categories);
        }

        // GET: Categories/Delete/5
        public ActionResult Delete(int id)
        {
            
            Categories categories = db.Categories.Find(id);
            if (categories == null)
            {
                return HttpNotFound();
            }

            _httpContextAccessor.HttpContext.Session.SetInt32("IdPost", id);
            _httpContextAccessor.HttpContext.Session.SetString("action", "Categories/Delete");

            return View(categories);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var action = _httpContextAccessor.HttpContext.Session.GetString("action");
            var idpost = _httpContextAccessor.HttpContext.Session.GetInt32("IdPost");

            if (idpost != id || action != "Categories/Delete")
                return RedirectToAction("Index");
            Categories categories = db.Categories.Find(id);
            db.Categories.Remove(categories);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}*/