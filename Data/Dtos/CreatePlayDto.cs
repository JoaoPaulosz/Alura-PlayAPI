using System.ComponentModel.DataAnnotations;

namespace Alura_Play.Data.Dtos
{
    public class CreatePlayDto
    { 

        [Required(ErrorMessage = "O Campo Nome é obrigatório para upload")]
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        [Required]
        public string Url { get; set; }
        public string Imagem { get; set; }
    }
}
