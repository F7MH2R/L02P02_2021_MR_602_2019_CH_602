using System.ComponentModel.DataAnnotations;

namespace L02P02_2021_MR_602_2019_CH_602.Models
{
    public class Libros
    {
        [Key]
        public int id { get; set; }
        public string? nombre { get; set; }
        public string? descripcion { get; set; }
        public string? url_imagen { get; set; }
        public int? id_autor { get; set; }
        public int? id_categoria { get; set; }

        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "El precio debe ser un número con hasta dos decimales.")]
        public decimal? precio { get; set; }
        public string? estado { get; set; }

    }
}
