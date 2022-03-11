using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class studentController : Controller
    {
        // GET: student
        myEntities db = new myEntities();
        public ActionResult Index()
        {
            List<student> data = db.students.ToList();
            return View("ind",data);
        }
    }
}