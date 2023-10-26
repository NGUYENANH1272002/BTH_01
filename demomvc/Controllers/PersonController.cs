using Microsoft.AspNetCore.Mvc;
using demomvc.Models;

namespace demomvc.Controllers{
    public class PersonController : Controller{
        public IActionResult Index (){
            return View();

        }
        [HttpPost]
        public IActionResult Index(Person ps){
            string str = "Hi " + ps.PersonID + " - " + ps.FullName.ToUpper();
            ViewBag.Tb= str;
            return View();
        }
    }
}