using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemeTuoi.Data;
using MemeTuoi.Interface;
using MemeTuoi.Models;
using Remotion.Linq.Clauses;

namespace MemeTuoi.Repositories
{
    public class MemeRepository : IMeme
    {
        private readonly ApplicationDbContext context;

        public MemeRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Meme> GetAllMeme()
        {
            return context.TMeme;
        }

        public Meme GetById(int id)
        {
            return context.TMeme.FirstOrDefault(m => m.MemeID == id);
        }

        public void Add(Meme newMeme)
        {
            context.TMeme.Add(newMeme);
            context.SaveChanges();
        }

        public void Update(Meme newMeme)
        {
            context.TMeme.Update(newMeme);
            context.SaveChanges();
        }

        public void Delete(Meme meme)
        {
            context.TMeme.Remove(meme);
            context.SaveChanges();
        }

        public IEnumerable<Meme> GetMemeByCategory(int theLoai)
        {
            IEnumerable<Meme> dsMemes = context.TMeme.Where(m => m.MemeCategory == theLoai);
            IEnumerable<Meme> newestMemes = dsMemes.Reverse();
            return newestMemes;
        }
    }
}
