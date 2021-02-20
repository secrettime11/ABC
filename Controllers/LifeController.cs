using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OwnBlog.Controllers
{
    public class LifeController : Controller
    {
        // GET: Life
        public ActionResult LifeMenu()
        {
            return View();
        }
    }
}