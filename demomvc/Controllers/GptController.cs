using Microsoft.AspNetCore.Mvc;
namespace demomvc.Controllers;
using demomvc.Models;
public class GptController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Solve(Abc Vanh)
    {
        if (Vanh.A == 0)
        {
            ViewBag.D = "A phai khac 0.";
            return View("Index", Vanh);
        }

        Vanh.Delta = Vanh.B * Vanh.B - 4 * Vanh.A * Vanh.C;
        ViewBag.A= "delta= " +Vanh.Delta;
        if (Vanh.Delta < 0)
        {
            ViewBag.B= "Phuong trinh khong vo nghiem.";
        }
        else if (Vanh.Delta == 0)
        {
            Vanh.X1 = -Vanh.B / (2 * Vanh.A);
            ViewBag.C = "Phuong trinh co nghiem kep: X1=X2="+Vanh.X1;
        }
        else
        {
            Vanh.X1 = (-Vanh.B + Math.Sqrt(Vanh.Delta)) / (2 * Vanh.A);
            Vanh.X2 = (-Vanh.B - Math.Sqrt(Vanh.Delta)) / (2 * Vanh.A);
           ViewBag.D ="Phuong trinh co 2 nghiem: " + " X1= " + Vanh.X1 + " ; "+ "X2 = " + Vanh.X2;
        }
         
       
        return View("Index", Vanh);
    }
}