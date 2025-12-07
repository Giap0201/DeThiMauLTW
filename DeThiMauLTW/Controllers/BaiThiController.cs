using DeThiMauLTW.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeThiMauLTW.Controllers
{
    public class BaiThiController : Controller
    {
        private readonly QlhangHoaContext _context;

        public BaiThiController(QlhangHoaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var hangHoas = _context.HangHoas.Where(x => x.Gia >= 100).ToList();
            return View(hangHoas);
        }

        public IActionResult GetHangHoa(int maLoai)
        {
            var hangHoas = _context.HangHoas
                                   .Where(x => x.MaLoai == maLoai)
                                   .ToList();

            return PartialView("_ListHangHoa", hangHoas);
        }

        public IActionResult FilterByName(string name)
        {
            var hangHoas = _context.HangHoas.Where(x => x.TenHang.Contains(name)).ToList();
            return PartialView("_listHangHoa", hangHoas);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}