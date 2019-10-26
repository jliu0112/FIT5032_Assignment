using HungrySouls_demo1.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HungrySouls_demo1.Controllers
{
   
    public class RatingsController : Controller
    {
        ApplicationDbContext _db = new ApplicationDbContext();
        // GET: Ratings
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SetRating(int StaffID ,decimal rank)
        {
            Rate rating = new Rate();
            rating.Rank = rank;
            rating.StaffID = StaffID;
            _db.Rates.Add(rating);
            _db.SaveChanges();
            return RedirectToAction ("Details","Staffs", new { id = StaffID});
        }
    }
}