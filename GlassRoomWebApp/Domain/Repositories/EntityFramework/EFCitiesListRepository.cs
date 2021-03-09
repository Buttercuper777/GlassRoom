using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using GlassRoomWebApp.Domain.Entities;
using GlassRoomWebApp.Domain.Repositories.Abstract;

namespace GlassRoomWebApp.Domain.Repositories.EntityFramework
{
    public class EFCitiesListRepository : ICityListRepository
    {
        private readonly AppDbContext context;
        public EFCitiesListRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<CitiesList> GetCity()
        {
            return context.CitiesOfList;
        }

        public CitiesList GetCityById(Guid id)
        {
            return context.CitiesOfList.FirstOrDefault(x => x.Id == id);
        }

        public void SaveCity(CitiesList entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteCity(Guid id)
        {
            context.CitiesOfList.Remove(new CitiesList() { Id = id });
            context.SaveChanges();
        }
    }
}
