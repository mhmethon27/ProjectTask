using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using blog2.Models;
using blog.Model;

namespace blog2.Controllers
{
    public class HomeController : Controller
    {
        private readonly blogContext db;
        public HomeController(blogContext eblogContext)
        {
            db = eblogContext;

        }

        public IActionResult Index()
        {
            ViewBag.List = db.post.ToList();
            ViewBag.List1 = db.comments.ToList();
            return View();
        }
         public IActionResult Get()
        {
            var kList = from p in db.comments
                        group p by p.postId into g
                        select new { Category = g.Key, ProductCount = g.Count() };

            var Post = db.post.ToList() ;

            var PostList = from po in Post join com in kList on po.id equals com.Category
                          

                           select new
                           {
                               id = po.id,
                               title = po.title,
                               description = po.description,
                               postdate = po.date,

                               Category = com.Category,
                               ProductCount = com.ProductCount,
                              
                           };
            return Json(PostList);

            //return View();

        }
        public IActionResult GetComt()
        {
            var CList = db.comments.ToList();
            return Json(CList);
        }
        public IActionResult count()
        {
            var kList = from p in db.comments
                        group p by p.postId into g
                        select new { Category = g.Key, ProductCount = g.Count() };
           
            return Json(kList);
        }

        public IActionResult Create([FromBody] comments com)
        {
            com.date = DateTime.Today;

            db.comments.Add(com);
            db.SaveChanges();


            return View();
        }
        public IActionResult AdminPost()
        {

            return View();
        }



            public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
