using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Api.Entities
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string NomeUsuario { get; set; } = string.Empty;
        public Carrinho? Carrinho { get; set; }

    }
}