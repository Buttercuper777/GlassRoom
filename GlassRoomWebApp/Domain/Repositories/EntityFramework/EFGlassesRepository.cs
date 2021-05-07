using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GlassRoomWebApp.Domain.Entities;
using GlassRoomWebApp.Domain.Repositories.Abstract;

namespace GlassRoomWebApp.Domain.Repositories.EntityFramework
{
    public class EFGlassesRepository : IGlassesRepository
    {

        private readonly AppDbContext context;
        public EFGlassesRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void DeleteGlass(int Id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<GlassCalc> GetGlasses()
        {
            return context.Glasses;
        }

        public int GetGlSize()
        {
            return context.Glasses.ToList().Last().id;
        }

        public float GetPriceByTypeTh(string type, int th)
        {
            return context.Glasses.FirstOrDefault(x => x.TypeGl == type && x.ThGl == th).PriceGl;
        }

        public void SaveGlass(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
