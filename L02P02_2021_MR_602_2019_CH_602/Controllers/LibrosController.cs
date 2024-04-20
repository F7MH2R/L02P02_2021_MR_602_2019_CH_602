using L02P02_2021_MR_602_2019_CH_602.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace L02P02_2021_MR_602_2019_CH_602.Controllers
{
    public class LibrosController : Controller
    {
        private readonly Context_Libreria _context;

        public LibrosController(Context_Libreria context)
        {
            _context = context;
        }

        // Acción para mostrar el listado de libros filtrados por el autor seleccionado
        public IActionResult ListByAuthor(int authorId)
        {
            // Obtener el nombre del autor
            var autor = _context.autores.FirstOrDefault(a => a.id == authorId);

            // Verificar si se encontró el autor
            if (autor != null)
            {
                // Establecer el nombre del autor en ViewBag
                ViewBag.AuthorName = autor.autor;
            }
            else
            {
                // Si no se encuentra el autor, establecer un mensaje de error
                ViewBag.AuthorName = "Autor no encontrado";
            }

            // Obtener los libros del autor
            var libros = _context.libros.Where(l => l.id_autor == authorId).ToList();

            // Devolver la vista con la lista de libros
            return View("Index", libros);
        }

        // Acción para mostrar el formulario de comentarios existentes del libro seleccionado
        public IActionResult ViewComments(int bookId)
        {
            var comentarios = _context.comentarios_libros.Where(c => c.id_libro == bookId).ToList();
            return View("~/Views/Comentario/Index.cshtml", comentarios);
        }

    }
}


