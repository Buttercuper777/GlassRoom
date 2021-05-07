using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using GlassRoomWebApp.Domain.Entities;
using GlassRoomWebApp.Domain.Repositories.Abstract;

namespace GlassRoomWebApp.Domain.Repositories.EntityFramework
{
    public class EFUserPhoneRepository : IUserPhoneRepository
    {
        private readonly AppDbContext context;
        public EFUserPhoneRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<UserPhone> GetUPDate()
        {
            return context.UserPhones;
        }

        public IQueryable<UserPhone> GetUserPhones()
        {
            return context.UserPhones;
        }

        public UserPhone GetUserPhoneById(Guid id)
        {
            return context.UserPhones.FirstOrDefault(x => x.Id == id);
        }

        public void SaveUserPhone(UserPhone entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteUserPhone(Guid id)
        {
            context.UserPhones.Remove(new UserPhone() { Id = id });
            context.SaveChanges();
        }

        public void CheckUserPhone(Guid id)
        {
           UserPhone Ch = GetUserPhoneById(id);
            if (Ch.Checked == true)
                Ch.Checked = false;
            else
                Ch.Checked = true;

            context.SaveChanges();
        }
    }
}
