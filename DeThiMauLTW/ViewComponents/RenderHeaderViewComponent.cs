using DeThiMauLTW.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeThiMauLTW.ViewComponents
{
    public class RenderHeaderViewComponent : ViewComponent
    {
        private readonly QlhangHoaContext _context;

        public RenderHeaderViewComponent(QlhangHoaContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var loaiHangs = _context.LoaiHangs.ToList();
            return View("RenderHeader", loaiHangs);
        }
    }
}