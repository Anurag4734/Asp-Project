using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class myController : Controller
    {
        // GET: my
        myEntities db = new myEntities();
        public ActionResult  Shaw()
        {
            List<myDetail> data = db.myDetails.ToList();
            return View(data);
        }
    }
}