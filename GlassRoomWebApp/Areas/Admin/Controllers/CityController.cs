using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GlassRoomWebApp.Domain;
using GlassRoomWebApp.Domain.Entities;
using GlassRoomWebApp.Service;

namespace GlassRoomWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public CityController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new CitiesList() : dataManager.CitiesOfList.GetCityById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(CitiesList model)
        {
            if (ModelState.IsValid)
            {
                dataManager.CitiesOfList.SaveCity(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.CitiesOfList.DeleteCity(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}