using System;
using System.Linq;
using GlassRoomWebApp.Domain.Entities;

namespace GlassRoomWebApp.Domain.Repositories.Abstract
{
    public interface ICityListRepository
    {
        IQueryable<CitiesList> GetCity();
        CitiesList GetCityById(Guid id);
        void SaveCity(CitiesList entity);
        void DeleteCity(Guid id);
    }
}
