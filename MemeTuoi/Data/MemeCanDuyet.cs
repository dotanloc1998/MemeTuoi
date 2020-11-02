using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MemeTuoi.Data
{
    public class MemeCanDuyet
    {
        [Key]
        public int MemeCanDuyetID { get; set; }
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

        public MemeCanDuyet()
        {
            
        }

        public MemeCanDuyet(int memeCanDuyetId, string memeName, string memeImgUrl, int memeCategory, string uploader)
        {
            MemeCanDuyetID = memeCanDuyetId;
            MemeName = memeName;
            MemeImgUrl = memeImgUrl;
            MemeCategory = memeCategory;
            Uploader = uploader;
        }
    }
}
