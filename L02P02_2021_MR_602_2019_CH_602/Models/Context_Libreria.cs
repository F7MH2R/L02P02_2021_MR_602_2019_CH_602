using Microsoft.EntityFrameworkCore;

namespace L02P02_2021_MR_602_2019_CH_602.Models
{
    public class Context_Libreria:DbContext
    {
        public Context_Libreria(DbContextOptions<Context_Libreria> options) : base(options) {
        
        
        }

        public DbSet<Libros> libros { get; set; }
        public DbSet<Pedido_Detalle> pedido_detalle { get; set; }
        public DbSet<Clientes> clientes { get; set; }
        public DbSet<Pedido_encabezado> pedido_encabezado { get; set; }

        public DbSet<Comentarios_libros> comentarios_libros { get; set; }
        public DbSet<Autores> autores { get; set; }
        public DbSet<Categorias> categorias { get; set; }







    }
}
