using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovies.Controllers {
    
    public class HelloWorldController : Controller {

        public string Index() { // index method is the default called if a method name isn't explicitly specified
            return "This is my default action...";            
        }

        public string Welcome(string name, int ID = 1) {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }

    }
}