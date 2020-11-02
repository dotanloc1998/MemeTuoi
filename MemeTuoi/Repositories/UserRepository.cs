using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemeTuoi.Data;
using MemeTuoi.Interface;
using Microsoft.AspNetCore.Identity;

namespace MemeTuoi.Repositories
{
    public class UserRepository : IUser
    {
        private ApplicationDbContext context;

        public UserRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<AppUser> GetAllUser()
        {
            return context.TUser;
        }

        public AppUser GetById(string id)
        {
            return context.TUser.FirstOrDefault(u => u.Id == id);
        }

        public void Delete(AppUser user)
        {
            context.TUser.Remove(user);
            context.SaveChanges();
        }
    }
}
