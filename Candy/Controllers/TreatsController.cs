using Microsoft.AspNetCore.Mvc;
using Candy.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Candy.Controllers
{
  public class TreatsController : Controller
  {
    private readonly CandyContext _db;
    public TreatsController(CandyContext db)
    {
      _db = db;
    }
    [HttpGet("/treats")]
    public ActionResult Index()
    {
      List<Treat> model = _db.Treats.ToList();
      return View(model);
    }
    [HttpGet("/treats/create")]
    public ActionResult Create()
    {
      return View();
    }
    [HttpPost("/treats/create")]
    public ActionResult Create(Treat treat)
    {
      _db.Treats.Add(treat);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      var thisTreat = _db.Treats
      .Include(treat => treat.TreatFlavors)
      .ThenInclude(join => join.Flavor)
      .FirstOrDefault(treat => treat.TreatId == id);
      return View(thisTreat);
    }

    public ActionResult Edit(int id)
    {
      var thisFlavor = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      return View(thisFlavor);
    }
    [HttpPost]
    public ActionResult Edit(Treat treat)
    {
      _db.Entry(treat).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Delete(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      return View(thisTreat);
    }
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      _db.Treats.Remove(thisTreat);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
