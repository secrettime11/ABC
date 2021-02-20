using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OwnBlog.Controllers
{
    public class TechController : Controller
    {
        // GET: Tech
        public ActionResult TechMenu()
        {
            return View();
        }
    }
}