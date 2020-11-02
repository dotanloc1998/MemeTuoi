using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MemeTuoi.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MemeTuoi.Models
{
    public class Meme
    {
        [Key]
        public int MemeID { get; set; }
        [Required(ErrorMessage = "Vui lòng không để trống!")]
        [DisplayName("Caption")]
        public string MemeName { get; set; }
        [Required(ErrorMessage = "Vui lòng không để trống!")]
        [DisplayName("Link ảnh/video")]
        public string MemeImgUrl { get; set; }
        [Required(ErrorMessage = "Vui lòng không để trống!")]
        [DisplayName("Thể loại meme")]
        public int MemeCategory { get; set; }
        [Required(ErrorMessage = "Vui lòng không để trống!")]
        [DisplayName("Lượt thích")]
        public int MemeUpvotes { get; set; } = 0;
        public string Uploader { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual TheLoai TheLoai { get; set; }
        public virtual ICollection<AppUserMeme> AppUserMemes { get; set; }

        public Meme(int memeId, string memeName, string memeImgUrl, int memeCategory, string uploader)
        {
            MemeID = memeId;
            MemeName = memeName;
            MemeImgUrl = memeImgUrl;
            MemeCategory = memeCategory;
            Uploader = uploader;
        }

        public Meme()
        {

        }
    }
}
