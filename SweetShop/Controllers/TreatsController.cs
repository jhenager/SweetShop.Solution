using Microsoft.AspNetCore.Mvc;
using SweetShop.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace SweetShop.Controllers
{
  public class TreatsController : Controller
  {
    private readonly SweetShopContext _db;
    // private readonly UserManager<ApplicationUser> _userManager;
    public TreatsController(SweetShopContext db)
    {
      _db = db;
    }
    public async Task<ActionResult> Index()
    {
      List<Treat> thisTreat = _db.Treats.ToList();
      return View(thisTreat);
    }
    [Authorize]
    public ActionResult Create()
    {
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "FlavorName");
      return View();
    }
    [HttpPost]
    public ActionResult Create(Treat treat)
    {
        _db.Treats.Add(treat);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
  }
}