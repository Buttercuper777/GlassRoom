using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GlassRoomWebApp.Domain;
using GlassRoomWebApp.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace GlassRoomWebApp.Models.ViewComponents
{
    public class CalculatorModel : ViewComponent
    {
        private readonly DataManager dataManager;

        public CalculatorModel(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }


        public IQueryable<GlassCalc> GlassPartial() {

            return dataManager.Glasses.GetGlasses();

        }

        public IEnumerable<FitCalc> FitPartial()
        {
            return dataManager.Fittings.GetFitCalcData();
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult((IViewComponentResult)View("Default", dataManager.Fittings.GetFitCalcData()));
        }

    }
}
