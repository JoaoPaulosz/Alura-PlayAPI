using System.ComponentModel.DataAnnotations;

namespace Alura_Play.Models
{
    public class Play
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="O Campo Nome é obrigatório para upload")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public string Url { get; set; }
        public string Imagem { get; set; }

    }
}
