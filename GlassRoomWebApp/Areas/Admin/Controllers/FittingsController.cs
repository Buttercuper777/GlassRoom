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
    public class FittingsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public FittingsController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }


        public IActionResult Edit(int id)
        {
            var entity = id == default ? new FitCalc() : dataManager.Fittings.GetFitCalcById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(FitCalc model)
        {
            if (ModelState.IsValid)
            {
                dataManager.Fittings.SaveFitting(model);
                return RedirectToAction(nameof(CalculatorController.Fittings), nameof(CalculatorController).CutController());
            }
            return View(model);
        }

        /*        [HttpPost]
                public IActionResult Delete(Guid id)
                {
                    dataManager.CitiesOfList.DeleteCity(id);
                    return RedirectToAction(nameof(HomeController.CitiesList), nameof(HomeController).CutController());
                }*/
    }
}
