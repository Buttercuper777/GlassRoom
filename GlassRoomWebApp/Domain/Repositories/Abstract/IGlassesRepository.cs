using System;
using System.Collections.Generic;
using System.Linq;
using GlassRoomWebApp.Domain.Entities;

namespace GlassRoomWebApp.Domain.Repositories.Abstract
{
    public interface IGlassesRepository
    {
        IQueryable<GlassCalc> GetGlasses();
        float GetPriceByTypeTh(string type, int th);
        void SaveGlass(int Id);
        void DeleteGlass(int Id);
        int GetGlSize();
        GlassCalc GetGlById(int Id);
        List<int> getGlassesTh();
        List<string> getGlassesTypes();
    }
}
