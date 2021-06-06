using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TH.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        [StringLength(20)]
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string Address { get; set; }
    }
}