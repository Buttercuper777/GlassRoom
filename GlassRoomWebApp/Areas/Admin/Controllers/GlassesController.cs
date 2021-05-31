using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GlassRoomWebApp.Domain;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using GlassRoomWebApp.Service;
using GlassRoomWebApp.Domain.Entities;

namespace GlassRoomWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GlassesController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public GlassesController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }


        public IActionResult Edit(int id)
        {
            var entity = id == default ? new GlassCalc() : dataManager.Glasses.GetGlById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(GlassCalc model)
        {
            if (ModelState.IsValid)
            {
                dataManager.Glasses.SaveGlass(model);
                return RedirectToAction(nameof(CalculatorController.Glasses), nameof(CalculatorController).CutController());
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            dataManager.Glasses.DeleteGlass(id);
            return RedirectToAction(nameof(CalculatorController.Glasses), nameof(CalculatorController).CutController());
        }
    }
}
