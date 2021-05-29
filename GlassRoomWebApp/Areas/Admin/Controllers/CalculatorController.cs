using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GlassRoomWebApp.Domain;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using GlassRoomWebApp.Service;

namespace GlassRoomWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CalculatorController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public CalculatorController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }

        
        public IActionResult Index()
        {
            return View(dataManager.UserOrders.GetUserOrders());
        }

        [HttpPost]
        public IActionResult Check(int id)
        {
            dataManager.UserOrders.CheckUserOrder(id);
            return RedirectToAction(nameof(CalculatorController.Index), nameof(CalculatorController).CutController());
        }
    }
}
