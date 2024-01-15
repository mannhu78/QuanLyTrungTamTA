using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MVC_Core_Quan_Ly_Trung_Tam_TA.DataBase
{

        public class TableGiangVien
        {
            [Key]
            public int MaGV { get; set; }
            public string TenGV { get; set; }
            public Nullable<DateTime> Ngaysinh { get; set; }
            public int DiaChi_id { get; set; }
            public string Diachi { get; set; }
        }
    }

