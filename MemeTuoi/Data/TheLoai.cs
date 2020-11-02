using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MemeTuoi.Models;

namespace MemeTuoi.Data
{
    public class TheLoai
    {
        [Key]
        public int TheLoaiId { get; set; }
        [Required(ErrorMessage = "Vui lòng không để trống!")]
        [DisplayName("Tên thể loại")]
        public string TenTheLoai { get; set; }
        [Required(ErrorMessage = "Vui lòng không để trống!")]
        [DisplayName("Link ảnh")]
        public string AnhTheLoai { get; set; }
        public virtual ICollection<Meme> Memes { get; set; }

        public TheLoai()
        {

        }

        public TheLoai(int theLoaiId, string tenTheLoai, string anhTheLoai)
        {
            TheLoaiId = theLoaiId;
            TenTheLoai = tenTheLoai;
            AnhTheLoai = anhTheLoai;
        }
    }
}
