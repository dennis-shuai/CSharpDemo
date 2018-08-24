using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebMVC.Models;
using PagedList;
using PagedList.Mvc;

namespace WebMVC.Controllers
{
    public class MoviesController : Controller
    {
        private MovieDBContent db = new MovieDBContent();

        // GET: Movies
        //public ActionResult Index()
        //{
        //    return View(db.Movies.ToList());
        //}
        //search 

        public ActionResult AutoComplete(string term)
        {
            var model = db.Movies.Where(m => m.Title.StartsWith(term)).Take(10)
                .Select(m => new 
                { 
                    label = m.Title 
                });
            return Json(model, JsonRequestBehavior.AllowGet);

        }
        [ChildActionOnly]
        [OutputCache(Duration=60)]
        public ActionResult SayHello()
        {
            return Content("hello jkxy");
        }

        //[OutputCache(Duration=5)]
        [OutputCache(CacheProfile="Long")]
        public ActionResult  Index(string movieGenre,string searchString,int page=1)
        {
            var GenreList = new List<string>();
            var GenreQry = from d in db.Movies
                           orderby  d.Genre
                           select  d.Genre;
            GenreList.AddRange(GenreQry.Distinct());
            ViewBag.movieGenre = new SelectList(GenreList);

            var movies = from m in db.Movies
                         select m;
            if (!string.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title.Contains(searchString));
            }
            if (!string.IsNullOrEmpty(movieGenre))
            {
                movies = movies.Where( x=> x.Genre == movieGenre);
            }
            var movieList = movies.OrderBy(m => m.Title)
                 .ToPagedList(page, 10);
            if (Request.IsAjaxRequest())
            {
                return PartialView("_Movies", movieList);
            }

            return View(movieList);
        }
        [HttpPost]
        public string Index(FormCollection fc, string searchstring)
        {
            return "<h3> from [httppost]index:" + searchstring + "</h3>";
        }

        // GET: Movies/Details/5
        [Authorize(Users="admin")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // GET: Movies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,ReleaseDate,Genre,Price")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movie);
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // POST: Movies/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,ReleaseDate,Genre,Price")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Movie movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
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
}
