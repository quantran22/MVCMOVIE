using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace DemoMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        // Action index
      public IActionResult Index(){
          return View();
      }
      public IActionResult Demo(){
          return View();
      }
    }
}