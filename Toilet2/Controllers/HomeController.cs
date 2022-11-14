using Codeplex.Data;
using Newtonsoft.Json;
using QuickType;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
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

            //add a new dispenser
            /*using (var webclient = new RestClient())
            {
                var endpoint = new Uri("http://node-express-env.eba-8bxzmgph.us-east-1.elasticbeanstalk.com/dispensers/create?bathroom_id=1&level=33&battery_level=33&mac_address=qwert&dispenser_type=soap");
                var request = new RestRequest(endpoint, Method.Post);
                RestResponse response = webclient.Execute(request);

            }*/

            //update a current dispenser, example id = 4
            using (var webclient = new RestClient())
            {
                var endpoint = new Uri("http://node-express-env.eba-8bxzmgph.us-east-1.elasticbeanstalk.com/dispensers/update/4?bathroom_id=1&level=33&battery_level=33&mac_address=abcde&dispenser_type=soap");
                var request = new RestRequest(endpoint, Method.Put);
                RestResponse response = webclient.Execute(request);

            }



            // deleted a dispenser, below it delete the dispenser id = 97
            /*using (var webclient = new RestClient())
            {
                var endpoint = new Uri("http://node-express-env.eba-8bxzmgph.us-east-1.elasticbeanstalk.com/dispensers/delete/97");
                var request = new RestRequest(endpoint,Method.Delete);
                RestResponse response = webclient.Execute(request);

            }*/

            // display all the dispenser
            using (var webclient = new WebClient())
            {
                string jsonstring = webclient.DownloadString("http://node-express-env.eba-8bxzmgph.us-east-1.elasticbeanstalk.com/dispensers/all");
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