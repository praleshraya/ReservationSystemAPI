using Microsoft.AspNetCore.Mvc;

namespace ReservationSystemAPI.Controllers
{
    public class UserController : Controller
    {
        /*public IActionResult Index()
         {
             return View();
         }
        */
        public string[] Get()
        {
            return new string[]
            {
             "Hello",
              "World"
            };
        }
    }
}
