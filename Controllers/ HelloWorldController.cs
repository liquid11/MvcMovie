using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers {
    public class HelloWorldController : Controller {
        // 
        // GET: /HelloWorld/

        public string Index () {
            //return "This is my default action...";
            
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome (string name, int numTimes = 1) {
            //return "This is the Welcome action method...";

            return HtmlEncoder.Default.Encode ($"hello {name}, NumTimes is : {numTimes}");
        }
    }
}