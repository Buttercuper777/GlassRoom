using Microsoft.AspNetCore.Mvc;
using GlassRoomWebApp.Domain;

namespace GlassRoomWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(dataManager.ServiceItems.GetServiceItems());
        }

        public IActionResult List()
        {
            return View(dataManager.ServiceItems.GetServiceItems());
        }
        public IActionResult CitiesList()
        {
            return View(dataManager.CitiesOfList.GetCity());
        }
    }
}