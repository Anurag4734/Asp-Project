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
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }
        public ActionResult SaveData(student student)
        {
            db.students.Add(student);
            db.SaveChanges();
            return RedirectToAction("Create");
        }

    }
}