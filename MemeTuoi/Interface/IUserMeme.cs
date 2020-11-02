using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemeTuoi.Data;

namespace MemeTuoi.Interface
{
    public interface IUserMeme
    {
        IEnumerable<AppUserMeme> GetAllAppUserMeme();
        AppUserMeme GetByMemeId(int id);
        AppUserMeme GetByUserId(string id);
        AppUserMeme GetByUserMemeId(int id);
        AppUserMeme GetByUserIdMemeId(string userId, int memeId);
        void Add(AppUserMeme newAppUserMeme);
        void Update(AppUserMeme updateAppUserMeme);
        void Delete(AppUserMeme deleteAppUserMeme);
    }
}
