using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;


namespace Toilet2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var txt = "";
            using (var client = new HttpClient())
            
            {
                var endpoint = new Uri("https://g5wdbckuah.execute-api.us-east-1.amazonaws.com/Prod/dispensers");
                var result = client.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                ViewBag.Message = json;
            }


                


            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Y.";

            return View();
        }

        static void Main(string[] args)
        {
            
        }
    }
}