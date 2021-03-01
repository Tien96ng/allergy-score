using Microsoft.AspNetCore.Mvc;
using Allergies.Models;

namespace Allergies.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult AllergyForm()
    {
      return View();
    }
    [Route("/results")]
    public ActionResult Results(int score)
    {
      AllergyScore allergy = new AllergyScore();
      allergy.Score = allergy.GetAllergyScore(score);
      return View(allergy);
    }
  }
}