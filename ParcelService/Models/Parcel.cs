using System.Collections.Generic;

namespace ParcelService.Models
{
  public class Parcel
  {
    public int Height {get;set;}
    public int Width {get; set;}
    public int Length {get;set;}
    public int Weight{get;set;}

    private static List<Parcel> _instances = new List<Parcel>{};

    public Parcel(int height, int width, int length, int weight)
    {
      Height = height;
      Width = width;
      Length = length;
      Weight = weight;
      _instances.Add(this);
    }

    public int Volume(int height, int width, int length)
    {
      int volume = height * width * length;
      return volume;
    }

    public static int CostToShip(int weight)
    {
      int cost = 0;
      if(weight < 5)
      {
        cost = 2;
      }
      else if(weight >= 5 && weight <= 10)
      {
        cost = 4;
      }
      else if(weight >= 10 && weight <= 20)
      {
        cost = 8;
      }
      else
      {
        cost = 13;
      }
      return cost;
    }

    public static List<Parcel> GetAll()
    {
      return _instances;
    }

    public static int GetTotal()
    {
      int totalCost = 0;
      List<Parcel> allParcels = Parcel.GetAll();
      foreach(Parcel parcel in allParcels)
      {
        totalCost += Parcel.CostToShip(parcel.Weight);
      }
      return totalCost;
    }

  }
}