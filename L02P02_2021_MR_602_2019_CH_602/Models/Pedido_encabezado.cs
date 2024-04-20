using System.ComponentModel.DataAnnotations;

namespace L02P02_2021_MR_602_2019_CH_602.Models
{
    public class Pedido_encabezado
    {
        [Key]
        public int id { get; set; }
        public int? id_cliente { get; set; }
        public int? cantidad_libros { get; set; }
        public decimal total { get; set; }
    }
}
