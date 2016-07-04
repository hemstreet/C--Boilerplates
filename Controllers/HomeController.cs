using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace aspnetcoreapp.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home
        public IActionResult Index() 
        {
            ViewData["specialParam"] = "Welcome to ASP.NET MVC!";
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
            
            return HtmlEncoder.Default.Encode(html);
        }    
    }
}
