using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GlassRoomWebApp.Domain.Entities;
using GlassRoomWebApp.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

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
            context.Glasses.Remove(new GlassCalc() { id = Id });
            context.SaveChanges();
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
                    try
                    {
                        if (ThList.Contains(GetGlById(i + 1).ThGl) == false)
                            ThList.Add(GetGlById(i + 1).ThGl);
                    }
                    catch
                    {
                        continue;
                    }
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
                    try
                    {
                        if (TyList.Contains(GetGlById(i + 1).TypeGl) == false)
                            TyList.Add(GetGlById(i + 1).TypeGl);
                    }
                    catch
                    {
                        continue;
                    }
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

        public void SaveGlass(GlassCalc entity)
        {
            if (entity.id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
