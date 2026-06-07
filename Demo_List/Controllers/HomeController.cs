using Demo_List.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
namespace Demo_List.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Staff> nv = new List<Staff>()
        {
            new Staff {ID = "NV01", FullName = "Mai Văn Minh Thiện",NumberPhone = "037121238", Email = "thienchupy@123", Address = "An Giang"},
            new Staff {ID = "NV02", FullName = "Hoàng Thành Nhân",NumberPhone = "0112113123", Email = "nhan@123", Address = "Trà Vinh"},
            new Staff {ID = "NV03", FullName = "Huỳnh Đức Thịnh",NumberPhone = "0212312355", Email = "Thinh@123", Address = "Sài Gòn"},
        };
            return View(nv);
        }
     
    }
}
