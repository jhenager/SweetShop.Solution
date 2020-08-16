using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using SweetShop.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SweetShop.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly SweetShopContext _db;
    public FlavorsController(SweetShopContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Flavor> model = _db.Flavors.ToList();
      return View(model);
    }

    
  }
}