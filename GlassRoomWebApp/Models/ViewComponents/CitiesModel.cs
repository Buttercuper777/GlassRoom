using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GlassRoomWebApp.Domain;

namespace GlassRoomWebApp.Models.ViewComponents
{
    public class CitiesModel : ViewComponent
    {
        private readonly DataManager dataManager;

        public CitiesModel(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult((IViewComponentResult)View("Default", dataManager.CitiesOfList.GetCity()));
        }
    }
}
