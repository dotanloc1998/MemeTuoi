using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemeTuoi.Data;

namespace MemeTuoi.Interface
{
    public interface IMemeCanDuyet
    {
        IEnumerable<MemeCanDuyet> GetAllMemeCanDuyet();
        MemeCanDuyet GetById(int id);
        void Add(MemeCanDuyet newMemeCanDuyet);
        void Update(MemeCanDuyet newMemeCanDuyet);
        void Delete(MemeCanDuyet newMemeCanDuyet);
    }
}
