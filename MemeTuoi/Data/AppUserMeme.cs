using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MemeTuoi.Models;

namespace MemeTuoi.Data
{
    public class AppUserMeme
    {
        [Key]
        public int AppUserMemeId { get; set; }
        public int MemeId { get; set; }
        public string UserId { get; set; }
        public string UporDown { get; set; }

        public virtual Meme Meme { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
