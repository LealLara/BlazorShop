using BlazorShop.Models.DTO;

namespace BlazorShop.Web.Services
{
    public class ProdutoService : IProdutoService
    {
        public HttpClient _httpClient;
        public ILogger<ProdutoService> _logger;
        public ProdutoService(HttpClient httpClient, ILogger<ProdutoService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<IEnumerable<ProdutoDTO>> GetItens()
        {
            try
            {
                var produtos = await _httpClient.GetFromJsonAsync<IEnumerable<ProdutoDTO>>("api/produtos");

                return produtos;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao acessar produtos: api/produtos");
                throw;
            }
        }
    }
}