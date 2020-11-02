using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemeTuoi.Models;

namespace MemeTuoi.Interface
{
    public interface IMeme
    {
        IEnumerable<Meme> GetAllMeme();
        Meme GetById(int id);
        void Add(Meme newMeme);
        void Update(Meme newMeme);
        void Delete(Meme newMeme);
        IEnumerable<Meme> GetMemeByCategory(int theLoai);
    }
}
