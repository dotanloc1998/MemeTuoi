using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemeTuoi.Models;
using Microsoft.AspNetCore.Identity;

namespace MemeTuoi.Data
{
    public class AppUser : IdentityUser
    {
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public virtual ICollection<Meme> Memes { get; set; }
        public virtual ICollection<AppUserMeme> AppUserMemes { get; set; }

        public AppUser()
        {

        }
    }
}
