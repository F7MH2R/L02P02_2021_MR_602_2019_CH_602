using System.ComponentModel.DataAnnotations;

namespace L02P02_2021_MR_602_2019_CH_602.Models
{
    public class Pedido_Detalle
    {
        [Key]
        public int id { get; set; }
        public int id_pedido { get; set; }
        public int id_libro { get; set; }
        public DateTime created_at { get; set; }
    }
}
