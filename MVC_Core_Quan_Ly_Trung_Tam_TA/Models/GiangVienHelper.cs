using Microsoft.AspNetCore.Mvc;

namespace MVC_Core_Quan_Ly_Trung_Tam_TA.Models
{
    public class GiangVienHelper 
    {
        public List<GiangVienModels> initGiangVien()
        {
            var items = new List<GiangVienModels>();
            for (int i = 0; i < 10; i++)
            {
                items.Add(new GiangVienModels()
                {
                    MaGV = i,
                    TenGV = $"Nguyen Van {i}",
                    DiaChi_id = i,
                    Diachi = $"Quan {i}, HCM",
                    Ngaysinh = new DateTime(1980, 01, 01)
                });
            }

            items = items.OrderByDescending(o => o.MaGV).ToList();
            return items;

        }

        public List<GiangVienModels> getGiangVientItem(int id)
        {
            var items = initGiangVien();
            var data = items.Where(w => w.MaGV == id).ToList();

            return data;

        }
    }
}
