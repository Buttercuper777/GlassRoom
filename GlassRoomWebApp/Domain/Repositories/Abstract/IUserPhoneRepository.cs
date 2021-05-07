using System;
using System.Linq;
using GlassRoomWebApp.Domain.Entities;

namespace GlassRoomWebApp.Domain.Repositories.Abstract
{
    public interface IUserPhoneRepository
    {
        IQueryable<UserPhone> GetUPDate();
        IQueryable<UserPhone> GetUserPhones();
        UserPhone GetUserPhoneById(Guid id);
        void SaveUserPhone(UserPhone entity);
        void DeleteUserPhone(Guid id);
        void CheckUserPhone(Guid id);
    }
}
