using System.ComponentModel.DataAnnotations;

namespace L02P02_2021_MR_602_2019_CH_602.Models
{
    public class Clientes
    {
        [Key]
        public int id { get; set; }
        public string? nombre { get; set; }
        public string? apellido { get; set; }
        public string? direccion { get; set; }
        public DateOnly? created_at { get; set; }

    }
}
