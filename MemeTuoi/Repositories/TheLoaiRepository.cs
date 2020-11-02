using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemeTuoi.Data;
using MemeTuoi.Interface;

namespace MemeTuoi.Repositories
{
    public class TheLoaiRepository : ITheLoai
    {
        private readonly ApplicationDbContext context;

        public TheLoaiRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<TheLoai> GetAllTheLoais()
        {
            return context.TTheLoai;
        }

        public TheLoai GetById(int id)
        {
            return context.TTheLoai.FirstOrDefault(t => t.TheLoaiId == id);
        }

        public void Add(TheLoai newTheLoai)
        {
            context.TTheLoai.Add(newTheLoai);
            context.SaveChanges();
        }

        public void Update(TheLoai theLoai)
        {
            context.TTheLoai.Update(theLoai);
            context.SaveChanges();
        }

        public void Delete(TheLoai theLoai)
        {
            context.TTheLoai.Remove(theLoai);
            context.SaveChanges();
        }
    }
}
