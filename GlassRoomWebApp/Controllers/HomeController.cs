using Microsoft.AspNetCore.Mvc;
using GlassRoomWebApp.Domain;

namespace GlassRoomWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageIndex"));
        }


        [HttpPost]
        public int GetFitSize()
        {
            return dataManager.Fittings.GetFitSize();
        }

        [HttpPost]
        public int GetGlSize()
        {
            return dataManager.Glasses.GetGlSize();
        }

        [HttpPost]
        public float GetGlassPrice(string type, int th)
        {
            return dataManager.Glasses.GetPriceByTypeTh(type, th);
        }

    }
}
