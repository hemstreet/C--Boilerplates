using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcoreapp.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home
        public IActionResult Index() 
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        // GET: /Home/Test/{id?}
        public string Test(string name, int numTimes = 1, int id = 0)
        {

            string html = $"Hello {name}, id: {numTimes}";

            if(id > 0)
            {
                // We have passed in a custom ID value
                html +=  $", optional ID: {id}";
            }

           return html;
            // return HtmlEncoder.Default.Encode(html);
        }    
    }
}
