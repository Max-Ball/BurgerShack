using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BurgerShack.db;
using BurgerShack.Models;

namespace BurgerShack.Repositories
{
  public class BurgersRepository
  {
    internal List<Burger> GetBurgers()
    {
      return Db.Burgers;
    }

    internal Burger GetBurgerById(int id)
    {
      Burger burger = Db.Burgers.Find(b => b.Id == id);
      if (burger != null)
      {
        return burger;
      }
      throw new Exception("No burger to be found");
    }

    internal Burger CreateBurger(Burger body)
    {
      body.Id = Db.Burgers.Count + 1;
      Db.Burgers.Add(body);
      return body;
    }

    internal Burger UpdateBurger(Burger body)
    {
      Burger original = GetBurgerById(body.Id);
      original.Name = body.Name != null ? body.Name : original.Name;
      original.Location = body.Location != null ? body.Location : original.Location;
      original.Toppings = body.Toppings ?? original.Toppings;
      original.Vegetarian = body.Vegetarian ?? original.Vegetarian;
      original.Patties = body.Patties ?? original.Patties;
      return original;
    }

    internal string DeleteBurger(int id)
    {
      Burger burger = GetBurgerById(id);
      if (!Db.Burgers.Remove(burger))
      {
        throw new Exception("No burgers to be deleted");
      }
      return $"{burger.Name} was deleted";
    }
  }
}