using Microsoft.AspNetCore.Mvc;

namespace Candy.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index() => View();
  }
}