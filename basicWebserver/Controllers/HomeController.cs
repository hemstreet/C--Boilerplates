using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace aspnetcoreapp.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home
        public string Index() 
        {
            return "Defualt Home controller root action";
        }

        // GET: /Home/Test
        public string Test(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, id: {numTimes}");
        }    
    }
}
