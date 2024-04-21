using L02P02_2021_MR_602_2019_CH_602.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace L02P02_2021_MR_602_2019_CH_602.Controllers
{
    public class AutoresController : Controller
    {
        private readonly Context_Libreria _context;

        public AutoresController(Context_Libreria context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var autores = _context.autores.ToList(); // Recuperar todos los autores desde la base de datos

            return View(autores); 
            // Pasar los autores a la vista
        }
    }
}

