using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemeTuoi.Data;

namespace MemeTuoi.Interface
{
    public interface ITheLoai
    {
        IEnumerable<TheLoai> GetAllTheLoais();
        TheLoai GetById(int id);
        void Add(TheLoai newTheLoai);
        void Update(TheLoai theLoai);
        void Delete(TheLoai theLoai);
    }
}
