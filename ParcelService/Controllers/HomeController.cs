using Microsoft.AspNetCore.Mvc;

namespace ParcelService.Controllers
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