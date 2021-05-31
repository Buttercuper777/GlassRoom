using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GlassRoomWebApp.Domain.Entities;

namespace GlassRoomWebApp.Domain.Repositories.Abstract
{
    public interface IFitCalcRepository
    {
        IQueryable<FitCalc> GetUPDate();
        IQueryable<FitCalc> GetFitCalcData();
        FitCalc GetFitCalcById(int id);
        float GetFitPriceByType(string type);
        void SaveFitting(FitCalc entity);
        void DeleteFitting(int id);
        int GetFitSize();
        List<string> getJsonList();

    }
}
