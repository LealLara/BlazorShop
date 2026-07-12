using BlazorShop.Api.Entities;

namespace BlazorShop.Api.Repositories
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> GetItens();
        Task<Produto> GetItem(int produtoId);
        Task<IEnumerable<Produto>> GetItensPorCategoria(int categoriaId);
    }
}