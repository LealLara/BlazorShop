using BlazorShop.Api.Entities;
using BlazorShop.Models.DTO;

namespace BlazorShop.Api.Mappings
{
    public static class MappingDtos
    {
        public static IEnumerable<CategoriaDTO> ConverterCategoriasParaDTO(this IEnumerable<Categoria> categorias)
        {
            return (from categoria in categorias
                    select new CategoriaDTO
                    {
                        Id = categoria.Id,
                        Nome = categoria.Nome,
                        IconCSS = categoria.IconCSS
                    }).ToList();
        }
        public static IEnumerable<ProdutoDTO> ConverterProdutosParaDTO(this IEnumerable<Produto> produtos)
        {
            return (from produto in produtos
                    select new ProdutoDTO
                    {
                        Id = produto.Id,
                        Nome = produto.Nome,
                        Descricao = produto.Descricao,
                        Preco = produto.Preco,
                        Quantidade = produto.Quantidade,
                        ImagemUrl = produto.ImagemUrl,
                        CategoriaId = produto.CategoriaId
                    }).ToList();
        }
        public static ProdutoDTO ConverterProdutoParaDTO(this Produto produto)
        {
            return new ProdutoDTO
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Descricao = produto.Descricao,
                Preco = produto.Preco,
                Quantidade = produto.Quantidade,
                ImagemUrl = produto.ImagemUrl,
                CategoriaId = produto.CategoriaId
            };
        }
        public static IEnumerable<CarrinhoItemDTO> ConverterCarrinhoItemsParaDTO(this IEnumerable<CarrinhoItem> carrinhoItems, IEnumerable<Produto> produtos)
        {
            return (from carrinhItem in carrinhoItems
                    join produto in produtos
                    on carrinhItem.ProdutoId equals produto.Id
                    select new CarrinhoItemDTO
                    {
                        Id = carrinhItem.Id,
                        ProdutoId = carrinhItem.ProdutoId,
                        ProdutoNome = produto.Nome,
                        ProdutoDescricao = produto.Descricao,
                        ProdutoImagemURL = produto.ImagemUrl,
                        Preco = produto.Preco,
                        CarrinhoId = carrinhItem.CarrinhoId,
                        Quantidade = carrinhItem.Quantidade,
                        PrecoTotal = produto.Preco * carrinhItem.Quantidade

                    }).ToList();
        }
        public static CarrinhoItemDTO ConverterCarrinhoItemParaDTO(this CarrinhoItem carrinhoItem, Produto produto)
        {
            return new CarrinhoItemDTO
            {
                Id = carrinhoItem.Id,
                ProdutoId = carrinhoItem.ProdutoId,
                ProdutoNome = produto.Nome,
                ProdutoDescricao = produto.Descricao,
                ProdutoImagemURL = produto.ImagemUrl,
                Preco = produto.Preco,
                CarrinhoId = carrinhoItem.CarrinhoId,
                Quantidade = carrinhoItem.Quantidade,
                PrecoTotal = produto.Preco * carrinhoItem.Quantidade
            };
        }
    }
}