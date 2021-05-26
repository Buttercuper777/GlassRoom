using Microsoft.AspNetCore.Mvc;
using GlassRoomWebApp.Domain;
using System.Collections.Generic;

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

        [HttpPost]
        public float GetFittPrice(string type)
        {
            return dataManager.Fittings.GetFitPriceByType(type);
        }

        public ActionResult GetFittingsTypes()
        {
            List<string> list = dataManager.Fittings.getJsonList();
            return Json(new
            {
                list
            }); 
        }

        public ActionResult GetGlassesThs()
        {
            List<int> list = dataManager.Glasses.getGlassesTh();
            return Json(new
            {
                list
            });
        }

        public ActionResult GetGlassesTypes()
        {
            List<string> list = dataManager.Glasses.getGlassesTypes();
            return Json(new
            {
                list
            });
        }
    }
}
