using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OwnBlog.Controllers
{
    public class TravelController : Controller
    {
        // GET: Travel
        public ActionResult TravelMenu()
        {
            return View();
        }
    }
}