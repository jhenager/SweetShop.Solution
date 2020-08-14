using Microsoft.AspNetCore.Mvc;

namespace SweetShop.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}