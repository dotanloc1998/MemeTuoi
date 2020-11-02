using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemeTuoi.Data;
using MemeTuoi.Interface;

namespace MemeTuoi.Repositories
{
    public class MemeCanDuyetRepository : IMemeCanDuyet
    {
        private readonly ApplicationDbContext context;

        public MemeCanDuyetRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<MemeCanDuyet> GetAllMemeCanDuyet()
        {
            return context.TMemeCanDuyet;
        }

        public MemeCanDuyet GetById(int id)
        {
            return context.TMemeCanDuyet.FirstOrDefault(m => m.MemeCanDuyetID == id);
        }

        public void Add(MemeCanDuyet newMemeCanDuyet)
        {
            context.TMemeCanDuyet.Add(newMemeCanDuyet);
            context.SaveChanges();
        }

        public void Update(MemeCanDuyet newMemeCanDuyet)
        {
            context.TMemeCanDuyet.Update(newMemeCanDuyet);
            context.SaveChanges();
        }

        public void Delete(MemeCanDuyet newMemeCanDuyet)
        {
            context.TMemeCanDuyet.Remove(newMemeCanDuyet);
            context.SaveChanges();
        }
    }
}
