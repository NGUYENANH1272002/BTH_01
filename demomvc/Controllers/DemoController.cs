using Microsoft.AspNetCore.Mvc;

namespace demomvc.Controllers;
public class DemoController : Controller{
    public IActionResult Index(){
        return View();

    }
    [HttpPost]
     public IActionResult Index(string fName, string ABC){
        string  str = "hello " + fName + "-" + ABC;
        ViewBag.L=str;
        return View();

    }
    
}