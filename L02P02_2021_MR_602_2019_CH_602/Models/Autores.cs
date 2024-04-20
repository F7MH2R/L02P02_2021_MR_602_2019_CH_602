using System.ComponentModel.DataAnnotations;

namespace L02P02_2021_MR_602_2019_CH_602.Models
{
    public class Autores
    {
        [Key]
        public int id { get; set; }
        public string? autor { get; set; }
    }
}
