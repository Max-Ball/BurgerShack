using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerShack.Models
{
  public class Burger
  {
    public Burger(string name, string location, int toppings, bool vegetarian, int patties, int id)
    {
      Name = name;
      Location = location;
      Toppings = toppings;
      Vegetarian = vegetarian;
      Patties = patties;
      Id = id;

    }
    public Burger()
    {

    }

    public string Name { get; set; }
    public string Location { get; set; }
    public int? Toppings { get; set; }
    public bool? Vegetarian { get; set; }
    public int? Patties { get; set; }

    public int Id { get; set; }

  }
}
