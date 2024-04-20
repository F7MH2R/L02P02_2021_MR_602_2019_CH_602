using Microsoft.AspNetCore.Mvc;
using L02P02_2021_MR_602_2019_CH_602.Models;
using System.Linq;

namespace L02P02_2021_MR_602_2019_CH_602.Controllers
{
    public class ConfirmarController : Controller
    {
        private readonly Context_Libreria _context;

        public ConfirmarController(Context_Libreria context)
        {
            _context = context;
        }

        public IActionResult Confirmacion()
        {
            // Obtener el último comentario del cliente
            var ultimoComentario = _context.comentarios_libros
                .OrderByDescending(c => c.created_at)
                .FirstOrDefault();

            if (ultimoComentario == null)
            {
                // Si no hay comentarios, devolver un error 404
                return NotFound();
            }

            return View(ultimoComentario);
        }
    }
}
