using Codeplex.Data;
using Newtonsoft.Json;
using QuickType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            // This is only for testing, will output the whole data as a big Json String
            /* 
            using (var client = new HttpClient())
            {
                var endpoint = new Uri("https://g5wdbckuah.execute-api.us-east-1.amazonaws.com/Prod/dispensers");
                var result = client.GetAsync(endpoint).Result;

                var json = result.Content.ReadAsStringAsync().Result;
                ViewBag.Message = json;
                
            }*/
            using (var webclient = new WebClient())
            {
                string jsonstring = webclient.DownloadString("https://g5wdbckuah.execute-api.us-east-1.amazonaws.com/Prod/dispensers");
                var datatable = Item.FromJson(jsonstring);
                ViewData["Item"] = datatable;
            }

            return View();
        }

        

        public ActionResult Contact()
        {
            ViewBag.Message = "Please use the following method to contact us!!!";

            return View();
        }

        static void Main(string[] args)
        {
            
        }
    }
}