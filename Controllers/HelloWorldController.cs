using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // public string Index()
        // {
        //     return "testeando";
        // }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Welcome(string name, int ID = 1)
        {
            ViewData["Mensagem"] = "hello" + name;
            ViewData["ID"] = ID;

            return View();
        }
        public string Welcome2(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}