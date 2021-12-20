using System.ComponentModel.DataAnnotations;

namespace Aula3.WebApp.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string? Unidade { get; set; }

        [Display(Name = "Peso em Gramas")]
        public int? PesoGramas { get; set; }
    }
}
