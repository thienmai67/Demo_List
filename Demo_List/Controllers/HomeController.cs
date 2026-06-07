using Demo_List.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo_List.Controllers
{
    public class HomeController : Controller
    {
        private static List<Staff> staffs = new List<Staff>()
        {
            new Staff
            {
                ID = "NV01",
                FullName = "Mai Văn Minh Thiện",
                NumberPhone = "037121238",
                Email = "thienchupy@123",
                Address = "An Giang"
            },
            new Staff
            {
                ID = "NV02",
                FullName = "Hoàng Thành Nhân",
                NumberPhone = "0112113123",
                Email = "nhan@123",
                Address = "Trà Vinh"
            },
            new Staff
            {
                ID = "NV03",
                FullName = "Huỳnh Đức Thịnh",
                NumberPhone = "0212312355",
                Email = "thinh@123",
                Address = "Sài Gòn"
            }
        };

        public IActionResult Index()
        {
            return View(staffs);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Staff staff)
        {
            staffs.Add(staff);

            return RedirectToAction("Index");
        }
    }
}