using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BurgerShack.Models;
using BurgerShack.Services;
using Microsoft.AspNetCore.Mvc;

namespace BurgerShack.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BurgersController : ControllerBase
  {
    private readonly BurgersService _burgersService;

    public BurgersController(BurgersService burgersService)
    {
      _burgersService = burgersService;
    }

    [HttpGet]
    public ActionResult<List<Burger>> GetBurgers()
    {
      try
      {
        List<Burger> burgers = _burgersService.GetBurgers();
        return Ok(burgers);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Burger> GetBurgerById(int id)
    {
      try
      {
        Burger burger = _burgersService.GetBurgerById(id);
        return Ok(burger);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Burger> CreateBurger([FromBody] Burger body)
    {
      try
      {
        Burger burger = _burgersService.CreateBurger(body);
        return Ok(burger);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut("{id}")]
    public ActionResult<Burger> UpdateBurger([FromBody] Burger body, int id)
    {
      try
      {
        body.Id = id;
        Burger burger = _burgersService.UpdateBurger(body);
        return Ok(burger);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<Burger> DeleteBurger(int id)
    {
      try
      {
        string message = _burgersService.DeleteBurger(id);
        return Ok(message);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}