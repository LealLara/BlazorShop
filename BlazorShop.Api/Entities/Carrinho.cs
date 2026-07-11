using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Api.Entities
{
    public class Carrinho
    {
        [Key]
        public int Id { get; set; }
        public int UsuarioId { get; set; }

        public Collection<CarrinhoItem> Itens { get; set; } = new();
    }
}