using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models.DTO
{
    public class CarrinhoItemAdicionaDTO
    {
        [Required]
        public int CarrinhoId { get; set; }
        [Required]
        public int ProdutoId { get; set; }
        [Required]
        public int Quantidade { get; set; }

    }
}