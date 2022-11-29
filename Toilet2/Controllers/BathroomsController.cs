using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Toilet2.Controllers
{
    public class BathroomsController : Controller
    {
        // GET: Bathrooms
        public ActionResult Index()
        {
            return View();
        }
    }
}