using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BurgerShack.Models;

namespace BurgerShack.db
{
  public static class Db
  {
    public static List<Burger> Burgers { get; set; } = new List<Burger>(){
      new Burger("Jalapeno Delight", "South Side", 4, false, 1, 1),
      new Burger("Ham & Cheese", "North Side", 3, false, 2, 2),
      new Burger("Black Bean Burger", "West Side", 5, true, 1, 3),
      new Burger("Veggie Delight", "East Side", 4, true, 2, 4),
      new Burger("Gut Buster", "Downtown", 10, false, 5, 5)
    };
  }
}