using System;
using System.Linq;
using GlassRoomWebApp.Domain.Entities;

namespace GlassRoomWebApp.Domain.Repositories.Abstract
{
    public interface IUserPhoneRepository
    {
        IQueryable<UserPhone> GetUserPhones();
        UserPhone GetUserPhoneById(Guid id);
        void SaveUserPhone(UserPhone entity);
        void DeleteUserPhone(Guid id);
    }
}
