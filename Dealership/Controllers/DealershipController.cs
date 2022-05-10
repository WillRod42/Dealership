using Microsoft.AspNetCore.Mvc;
using Dealership.Models;
using System.Collections.Generic;

namespace Dealership.Controllers
{
  public class DealershipController : Controller
  {
    [HttpGet("/dealership/form")]
    public ActionResult Form()
    {
      return View();
    }
    [HttpPost("/dealership/display")]
    public ActionResult Display(string make, string model, int price, int miles)
    {
      Car newCar = new Car(make, model, price, miles);
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }
  }
}