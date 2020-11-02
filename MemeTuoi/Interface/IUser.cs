using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemeTuoi.Data;
using Microsoft.AspNetCore.Identity;

namespace MemeTuoi.Interface
{
    public interface IUser
    {
        IEnumerable<AppUser> GetAllUser();
        AppUser GetById(string id);
        void Delete(AppUser newUser);
    }
}
