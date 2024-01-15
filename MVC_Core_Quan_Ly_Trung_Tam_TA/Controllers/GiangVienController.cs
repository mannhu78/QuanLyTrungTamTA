using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Core_Quan_Ly_Trung_Tam_TA.Models;

namespace MVC_Core_Quan_Ly_Trung_Tam_TA.Controllers
{
    public class GiangVienController : Controller
    {
        public IActionResult Index(int id)
        {
            var studentHelper = new GiangVienHelper();
            List<GiangVienModels> dataItems = new List<GiangVienModels>();
            if (id == 0)
                dataItems = studentHelper.initGiangVien();
            else
                dataItems = studentHelper.getGiangVientItem(id);

            return View(dataItems);
        }
        public IActionResult GiangVien(int id)
        {
            var item = new GiangVienModels(id);
            return View(item);
        }
        public IActionResult class_student(int id)
        {
            return View();
        }
        public IActionResult course(int id)
        {
            return View();
        }
        public IActionResult point(int id)
        {
            return View();
        }
        public IActionResult edu_result(int id)
        {
            return View();
        }
    }
}
