using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NVT_Lesson06.Models
{
    public class NVTSong
    {
        public int Id { get; set; }
        [DisplayName("Tiêu đề")]
        [Required(ErrorMessage ="NVT: Hãy nhập tiêu đề")]
        public string nvtTitle { get; set; }
        [DisplayName("Tác giả")]
        [Required(ErrorMessage = "NVT: Hãy nhập tác giả")]
        public string nvtAuthor { get; set; }
        [DisplayName("Nghệ sĩ")]
        [Required(ErrorMessage = "NVT: Hãy nhập nghệ sĩ")]
        [StringLength(50, MinimumLength=2, ErrorMessage = "NVT: Độ dài trong khoảng [2-50]")]
        public string nvtArtist { get; set; }
        [Required(ErrorMessage = "NVT: Hãy nhập năm xuất bản")]
        [RegularExpression(@"[0-9]{4}", ErrorMessage ="NVT=Năm xuất bản phải có 4 kí tự số")]
        [Range(1900,2020,ErrorMessage ="NVT: năm xuất bản từ 1900-2020")]
        public int nvtYearRelease { get; set; }
        
    }
}