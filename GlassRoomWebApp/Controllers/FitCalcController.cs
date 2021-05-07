using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GlassRoomWebApp.Domain;
using GlassRoomWebApp.Domain.Entities;
using GlassRoomWebApp.Service;
using System.Threading.Tasks;
using GlassRoomWebApp.Models;
using Microsoft.AspNetCore.Identity;

namespace GlassRoomWebApp.Controllers
{
    public class FitCalcController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;

        public FitCalcController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Out(FitCalc model)
        {
            dataManager.Fittings.GetFitCalcById(model.id);
            return NoContent();
        }

    }
}
