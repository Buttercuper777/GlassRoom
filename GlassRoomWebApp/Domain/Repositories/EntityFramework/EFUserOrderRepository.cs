using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using GlassRoomWebApp.Domain.Entities;
using GlassRoomWebApp.Domain.Repositories.Abstract;

namespace GlassRoomWebApp.Domain.Repositories.EntityFramework
{
    public class EFUserOrderRepository : IUserOrderRepository
    {

        private readonly AppDbContext context;
        public EFUserOrderRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void CheckUserOrder(int id)
        {
        UserOrder Ch = GetUserOrderById(id);
            if (Ch.Checked == true)
                Ch.Checked = false;
            else
                Ch.Checked = true;

            context.SaveChanges();
        }

        public void DeleteUserOrder(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<UserOrder> GetUPDate()
        {
            return context.UserOrders;
        }

        public UserOrder GetUserOrderById(int id)
        {
            return context.UserOrders.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<UserOrder> GetUserOrders()
        {
            return context.UserOrders;
        }

        public void SaveUserOrder(UserOrder entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}