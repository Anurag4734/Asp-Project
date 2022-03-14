using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public ActionResult Edit(int id)
        {
            student data = db.students.Find(id);
           // student data = db.students.FirstOrDefault(x => x.id == id);  
           //(for finding data using column other than id)
            return View(data);
        }

        public ActionResult UpdateData(student student)
        {
           // student std =db.students.Find(student.sid);
            db.Entry(student).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            student student = db.students.Find(id);
            return View(student);
        }

        public ActionResult DeleteData(student student)
        {
            student delete = db.students.Find(student.sid);
            db.students.Remove(delete);
            return RedirectToAction("Index");
        }

    }
}