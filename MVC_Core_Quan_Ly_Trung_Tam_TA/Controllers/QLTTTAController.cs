using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Core_Quan_Ly_Trung_Tam_TA.Models;

namespace MVC_Core_Quan_Ly_Trung_Tam_TA.Controllers
{
    public class QLTTTAController : Controller
    {
        public IActionResult _GiangVien(int id)
        {
            var GiangVienHelper = new GiangVienHelper();
            List<GiangVienModels> dataItems = new List<GiangVienModels>();
            if (id == 0)
                dataItems = GiangVienHelper.initGiangVien();
            else
                dataItems = GiangVienHelper.getGiangVientItem(id);

            return View(dataItems);
        }
        public IActionResult GiangVien(int id)
        {
            var item = new GiangVienModels(id);
            return View(item);
        }
        public IActionResult _HocVien(int id)
        {
            return View();
        }
        public IActionResult _GhiDanh(int id)
        {
            return View();
        }
        public IActionResult _LopHoc(int id)
        {
            return View();
        }
        public IActionResult _KhoaHoc(int id)
        {
            return View();
        }
        public IActionResult _BaoCaoHocVien(int id)
        {
            return View();
        }
    }
}
