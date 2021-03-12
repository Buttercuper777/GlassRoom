using Microsoft.AspNetCore.Mvc;
using GlassRoomWebApp.Domain;

namespace GlassRoomWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiseListController : Controller
    {
        private readonly DataManager dataManager;

        public ServiseListController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult List()
        {
            return View(dataManager.ServiceItems.GetServiceItems());
        }
    }
}
