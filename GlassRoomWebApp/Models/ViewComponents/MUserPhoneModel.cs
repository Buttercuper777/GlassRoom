﻿using GlassRoomWebApp.Domain;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using GlassRoomWebApp.Domain.Entities;
using System;

namespace GlassRoomWebApp.Models
{
    public class MUserPhone : ViewComponent
    {
        private readonly DataManager dataManager;

        public MUserPhone(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IViewComponentResult Invoke(UserPhone model)
        {
            return View("Default", model);
        }
    }

}
