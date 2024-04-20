using L02P02_2021_MR_602_2019_CH_602.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace L02P02_2021_MR_602_2019_CH_602.Controllers
{
    public class AutoresController : Controller
    {
        private readonly Context_Libreria _context;

        public AutoresController(Context_Libreria context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var autores = await _context.autores.ToListAsync();
            return View();

        }



    }
}
