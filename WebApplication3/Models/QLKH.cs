using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    [Table("QLKHs")]
    public class QLKH
    {
        [Key]
        public int IDKhachHang { get; set; }
        public string TenKH { get; set; }

        public string DiaChi { get; set; }
    }
}