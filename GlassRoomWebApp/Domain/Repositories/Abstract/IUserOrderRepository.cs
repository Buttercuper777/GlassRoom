using System;
using System.Linq;
using GlassRoomWebApp.Domain.Entities;

namespace GlassRoomWebApp.Domain.Repositories.Abstract
{
    public interface IUserOrderRepository
    {
        IQueryable<UserOrder> GetUPDate();
        IQueryable<UserOrder> GetUserOrders();
        UserOrder GetUserOrderById(int id);
        void SaveUserOrder(UserOrder entity);
        void DeleteUserOrder(int id);
        void CheckUserOrder(int id);
        void SetOrderNote(int id, string note);
        string GetOrderNote(int id);
    }
}
