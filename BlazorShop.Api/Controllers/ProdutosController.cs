using BlazorShop.Api.Mappings;
using BlazorShop.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BlazorShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly ILogger<ProdutosController> _logger;
        private readonly IProdutoRepository _produtosRepository;
        public ProdutosController(ILogger<ProdutosController> logger, IProdutoRepository produtosRepository)
        {
            _logger = logger;
            _produtosRepository = produtosRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetItens()
        {
            try
            {
                var produtos = await _produtosRepository.GetItens();
                if (produtos == null || !produtos.Any())
                {
                    return NotFound("Produtos não localizados.");
                }
                else
                {
                    var produtoDTOs = produtos.ConverterProdutosParaDTO();
                    return Ok(produtoDTOs);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar o banco de dados");
            }
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetItem(int id)
        {
            try
            {
                var produto = await _produtosRepository.GetItem(id);
                if (produto == null)
                {
                    return NotFound("Produto não localizado.");
                }
                else
                {
                    var produtoDTO = produto.ConverterProdutoParaDTO();
                    return Ok(produtoDTO);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar o banco de dados");
            }
        }
        [HttpGet]
        [Route("GetItensPorCategoria/{categoriaId}")]
        public async Task<IActionResult> GetItensPorCategoria(int categoriaId)
        {
            try
            {
                var produtos = await _produtosRepository.GetItensPorCategoria(categoriaId);
                if (produtos == null || !produtos.Any())
                {
                    return NotFound("Produtos não localizados.");
                }
                else
                {
                    var produtoDTOs = produtos.ConverterProdutosParaDTO();
                    return Ok(produtoDTOs);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar o banco de dados");
            }
        }
    }
}