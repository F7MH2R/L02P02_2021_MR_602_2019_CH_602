using System.ComponentModel.DataAnnotations;

namespace L02P02_2021_MR_602_2019_CH_602.Models
{
    public class Comentarios_libros
    {
        [Key]
        public int id { get; set; }
        public int? id_libro { get; set; }
        public string? comentarios { get; set; }
        public string? usuario { get; set; }
        public DateOnly? created_at { get; set; }
    }
}
