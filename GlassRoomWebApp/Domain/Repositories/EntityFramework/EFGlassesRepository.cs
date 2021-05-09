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

        public List<int> getGlassesTh()
        {
            List<int> ThList = new List<int>();
            int size = GetGlSize();
            if (size >= 1)
            {
                for (int i = 0; i < size; i++)
                {
                    if (ThList.Contains(GetGlById(i + 1).ThGl) == false)
                        ThList.Add(GetGlById(i + 1).ThGl);
                }

                return ThList;
            }
            else
            {
                ThList.Add(-1);
                return ThList;
            }
        }

        public List<string> getGlassesTypes()
        {
            int size = GetGlSize();
            List<string> TyList = new List<string>();
            if (size >= 1)
            {
                for (int i = 0; i < size; i++)
                {
                    if (TyList.Contains(GetGlById(i + 1).TypeGl) == false)
                        TyList.Add(GetGlById(i + 1).TypeGl);
                }

                return TyList;
            }
            else
            {
                TyList.Add("Empty");
                return TyList;
            }
        }


        public GlassCalc GetGlById(int Id)
        {
            return context.Glasses.FirstOrDefault(x => x.id == Id);
        }

        public int GetGlSize()
        {
            return context.Glasses.ToList().Last().id;
        }

        public float GetPriceByTypeTh(string type, int th)
        {
            try
            {
                return context.Glasses.FirstOrDefault(x => x.TypeGl == type && x.ThGl == th).PriceGl;
            }
            catch
            {
                return -1;
            }
        }

        public void SaveGlass(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
