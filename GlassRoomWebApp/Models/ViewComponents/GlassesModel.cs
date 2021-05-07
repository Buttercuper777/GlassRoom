using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GlassRoomWebApp.Domain;
using GlassRoomWebApp.Domain.Entities;

namespace GlassRoomWebApp.Models.ViewComponents
{
    public class GlassesModel
    {
        private readonly DataManager dataManager;

        public GlassesModel(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
       
    }
}
