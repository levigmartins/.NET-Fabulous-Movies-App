using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovies.Controllers {
    
    public class HelloWorldController : Controller {

        public IActionResult Index() { // index method is the default called if a method name isn't explicitly specified
            return View();
        }

    }
}