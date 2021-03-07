using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public ActionResult Welcome(string name, int ID = 1)
        {
            ViewBag.Message = $"Hello {name}";
            ViewBag.ID = ID;

            return View();
        }
    }
}