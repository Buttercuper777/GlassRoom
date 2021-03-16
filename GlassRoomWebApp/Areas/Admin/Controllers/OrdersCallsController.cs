using Microsoft.AspNetCore.Mvc;
using GlassRoomWebApp.Domain;

namespace GlassRoomWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrdersCallsController : Controller
    {
        private readonly DataManager dataManager;

        public OrdersCallsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
