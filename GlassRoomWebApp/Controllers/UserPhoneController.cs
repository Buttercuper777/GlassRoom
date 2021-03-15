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
    public class UserPhoneController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;

        public UserPhoneController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }

        [HttpPost]
        public IActionResult Edit(UserPhone model)
        {
            dataManager.UserPhones.SaveUserPhone(model);
            return NoContent() ;
        }
    }
}
