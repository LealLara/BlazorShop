using BlazorShop.Models.DTO;

namespace BlazorShop.Web.Services
{
    public interface IProdutoService
    {
        Task<IEnumerable<ProdutoDTO>> GetItens();
    }
}