using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GlassRoomWebApp.Domain.Entities;
using GlassRoomWebApp.Domain.Repositories.Abstract;

namespace GlassRoomWebApp.Domain.Repositories.EntityFramework
{
    public class EFFittingsRepository : IFitCalcRepository
    {
        private readonly AppDbContext context;
        
        public EFFittingsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void DeleteFitting(int Id)
        {
            context.Fittings.Remove(new FitCalc() { id = Id });
            context.SaveChanges();
        }

        public FitCalc GetFitCalcById(int id)
        {
            return context.Fittings.FirstOrDefault(x => x.id == id);  
        }

        public IQueryable<FitCalc> GetFitCalcData()
        {
            return context.Fittings;
        }

        public float GetFitPriceByType(string type)
        {
            return context.Fittings.FirstOrDefault(x => x.TypeFit == type).PriceFit;
        }

        public int GetFitSize()
        {
            return context.Fittings.ToList().Last().id;
        }

        public IQueryable<FitCalc> GetUPDate()
        {
            throw new NotImplementedException();
        }

        public void SaveFitting(int id)
        {
            throw new NotImplementedException();
        }
    }
}
