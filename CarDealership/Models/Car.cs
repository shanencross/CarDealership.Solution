using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }

    public static List<Car> _instances = new List<Car> {};

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;

      _instances.Add(this);
    }

    public static List<Car> GetCarsWorthBuying(int maxPrice)
    {
      List<Car> carsWorthBuying = new List<Car> {};

      foreach (Car car in _instances)
      {
        if (car.WorthBuying(maxPrice))
        {
          carsWorthBuying.Add(car);
        }
      }

      return carsWorthBuying;
    }

    private bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }
  }
}