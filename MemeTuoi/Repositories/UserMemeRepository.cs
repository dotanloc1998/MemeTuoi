using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemeTuoi.Data;
using MemeTuoi.Interface;

namespace MemeTuoi.Repositories
{
    public class UserMemeRepository : IUserMeme
    {
        private readonly ApplicationDbContext context;
        public UserMemeRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public AppUserMeme GetByUserMemeId(int id)
        {
            return context.TAppUserMeme.FirstOrDefault(e => e.AppUserMemeId == id);
        }

        public IEnumerable<AppUserMeme> GetAllAppUserMeme()
        {
            return context.TAppUserMeme;
        }

        public AppUserMeme GetByUserId(string id)
        {
            return context.TAppUserMeme.FirstOrDefault(e => e.UserId == id);
        }

        public AppUserMeme GetByMemeId(int id)
        {
            return context.TAppUserMeme.FirstOrDefault(e => e.MemeId == id);
        }
        public void Add(AppUserMeme newAppUserMeme)
        {
            context.TAppUserMeme.Add(newAppUserMeme);
            context.SaveChanges();
        }

        public void Update(AppUserMeme updateAppUserMeme)
        {
            context.TAppUserMeme.Update(updateAppUserMeme);
            context.SaveChanges();
        }

        public void Delete(AppUserMeme deleteAppUserMeme)
        {
            context.TAppUserMeme.Remove(deleteAppUserMeme);
            context.SaveChanges();
        }

        public AppUserMeme GetByUserIdMemeId(string userId, int memeId)
        {
            return context.TAppUserMeme.FirstOrDefault(e => e.MemeId == memeId && e.UserId == userId);
        }
    }
}
