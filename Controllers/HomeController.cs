using ExamenWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ExamenWeb.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index() 
        {
            return View();
        }
        
        [HttpPost]
        public async Task<ActionResult> Index(User user)
        {
            using (var client = new HttpClient())
            {
                //var json = JsonConvert.SerializeObject(user);
                //var data = new StringContent(json, Encoding.UTF8, "application/json");


                var url = "http://localhost:5001/api/Products";
                var json = await client.GetStreamAsync(url);
                //var postTask  = await client.PostAsync(url, data);
                //string result = postTask.Content.ReadAsStringAsync().Result;



                if (true)
                {

                    return RedirectToAction("About", "Home");
                }
                else
                {
                    return View(user);
                }
            }
        }

        public async Task<ActionResult> About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}