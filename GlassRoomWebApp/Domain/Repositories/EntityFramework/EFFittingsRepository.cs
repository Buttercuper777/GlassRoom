using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GlassRoomWebApp.Domain.Entities;
using GlassRoomWebApp.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

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

        public List<string> getJsonList()
        {
            List<string> TypeList = new List<string>();
            if (GetFitSize() >= 1)
            {
                string uType = GetFitCalcById(1).TypeFit;
                TypeList.Add(uType);
                {
                    for (int i = 1; i <= GetFitSize(); i++)
                    {
                        try
                        {
                            if (GetFitCalcById(i).TypeFit != uType)
                            {
                                uType = GetFitCalcById(i).TypeFit;
                                TypeList.Add(uType);
                            }
                        }
                        catch
                        {
                            continue;
                        }
                    }
                }


                return TypeList;
            }
            else
            {
                TypeList.Add("Empty");
                return TypeList;
            }
        }

        public IQueryable<FitCalc> GetUPDate()
        {
            return context.Fittings;
        }

        public void SaveFitting(FitCalc entity)
        {
            if (entity.id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
