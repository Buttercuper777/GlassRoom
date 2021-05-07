using Microsoft.AspNetCore.Mvc;
using GlassRoomWebApp.Domain;
using System;
using GlassRoomWebApp.Service;

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

        [HttpPost]
        public IActionResult Check(Guid id)
        {
            dataManager.UserPhones.CheckUserPhone(id);
            return RedirectToAction(nameof(HomeController.OrdersCalls), nameof(HomeController).CutController());
        }
    }
}
