using System.Collections.Generic;
namespace Dealership.Models
{
  public class Car
  {
    public string Make {get; set;}
    public string Model {get; set;}
    public int Price {get; set;}
    public int Miles {get; set;}
    private static List<Car> _carList = new List<Car>();

    public Car(string make, string model, int price, int miles)
    {
      Make = make;
      Model = model;
      Price = price;
      Miles = miles;
      _carList.Add(this);
    }
    public static List<Car> GetAll()
    {
      return _carList;
    }
  }
}