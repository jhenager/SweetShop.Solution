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
    public ActionResult Create(Treat treat, int FlavorId)
    {
        _db.Treats.Add(treat);
        if (FlavorId != 0)
          {
            _db.TreatFlavor.Add(new TreatFlavor() {FlavorId = FlavorId, TreatId = treat.TreatId});
          }
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      var thisTreat = _db.Treats
        .Include(treat => treat.Flavors)
        .ThenInclude(join => join.Flavor)
        .FirstOrDefault(treat => treat.TreatId == id);
      return View(thisTreat);
    }
    [Authorize]
    public ActionResult Edit(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "FlavorName");
      return View(thisTreat);
    }

    [HttpPost]
    public ActionResult Edit(Treat treat, int FlavorId)
    {
        var existingConnection = _db.TreatFlavor.FirstOrDefault(join => join.TreatId == treat.TreatId && join.FlavorId == FlavorId);
        if (existingConnection == null && FlavorId != 0)
        {
          _db.TreatFlavor.Add(new TreatFlavor() {FlavorId = FlavorId, TreatId = treat.TreatId});
        }
        _db.Entry(treat).State = EntityState.Modified;
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
    [Authorize]
    public ActionResult Delete(int id)
    {
        var thisTreat = _db.Treats.FirstOrDefault(treats => treats.TreatId == id);
        return View(thisTreat);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        var thisTreat = _db.Treats.FirstOrDefault(treats => treats.TreatId == id);
        _db.Treats.Remove(thisTreat);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
    [HttpPost]
    public ActionResult DeleteFlavor (int joinId)
    {
      var joinEntry = _db.TreatFlavor.FirstOrDefault(entry => entry.TreatFlavorId == joinId);
      _db.TreatFlavor.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddFlavor(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(treats => treats.TreatId == id);
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "FlavorName");
      return View(thisTreat);
    }

    [HttpPost]
    public ActionResult AddFlavor(Treat treat, int FlavorId)
    {
        if (FlavorId != 0)
        {
          _db.TreatFlavor.Add(new TreatFlavor() {FlavorId = FlavorId, TreatId = treat.TreatId});
        }
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
  }
}