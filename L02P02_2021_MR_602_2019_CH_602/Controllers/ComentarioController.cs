using Microsoft.AspNetCore.Mvc;
using L02P02_2021_MR_602_2019_CH_602.Models;
using System.Linq;

namespace L02P02_2021_MR_602_2019_CH_602.Controllers
{
    public class ComentarioController : Controller
    {
        private readonly Context_Libreria _context;

        public ComentarioController(Context_Libreria context)
        {
            _context = context;
        }

        // Acción para mostrar los comentarios existentes de un libro

        public IActionResult ViewComments(int libroId)
        {
            // Obtener el libro correspondiente al ID proporcionado
            var libro = _context.libros.FirstOrDefault(l => l.id == libroId);

            // Verificar si se encontró el libro
            if (libro != null)
            {
                // Obtener el nombre del autor del libro
                var autor = _context.autores.FirstOrDefault(a => a.id == libro.id_autor);

                // Pasar el nombre del autor y el nombre del libro a la vista
                ViewBag.AuthorName = autor?.autor;
                ViewBag.BookName = libro.nombre;
            }
            else
            {
                // Si no se encuentra el libro, devolver un error 404
                return NotFound();
            }

            // Obtener los comentarios del libro con el ID libroId
            var comentarios = _context.comentarios_libros.Where(c => c.id_libro == libroId).ToList();

            // Pasar los comentarios a la vista
            return View(comentarios);
        }


        // Acción para mostrar el formulario de creación de comentarios
        public IActionResult CrearComentario(int libroId)
        {
            // Puedes pasar el ID del libro como un parámetro en la URL o mediante un formulario oculto
            ViewBag.LibroId = libroId;
            return View();
        }
  
        public IActionResult GuardarComentario(Comentarios_libros comentario)
        {
            if (ModelState.IsValid)
            {
                // Guardar el comentario en la base de datos
                _context.comentarios_libros.Add(comentario);
                _context.SaveChanges();

                // Redireccionar a la acción de confirmación en el controlador Confirmar
                return RedirectToAction("Index", "Confirmar");
            }
            else
            {
                // Si el modelo no es válido, volver al formulario de creación de comentarios
                return View("CrearComentario", comentario);
            }
        }
    }
}



