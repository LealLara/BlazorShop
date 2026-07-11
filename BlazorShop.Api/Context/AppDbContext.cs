using BlazorShop.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop.Api.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Produto>? Produtos { get; set; }
        public DbSet<Carrinho>? Carrinhos { get; set; }
        public DbSet<CarrinhoItem>? CarrinhoItens { get; set; }
        public DbSet<Usuario>? Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria { 
                    Id = 1, 
                    Nome = "Eletrônicos", 
                    IconCSS = "fas fa-tv" 
                },
                new Categoria { 
                    Id = 2, 
                    Nome = "Roupas", 
                    IconCSS = "fas fa-tshirt" 
                },
                new Categoria { 
                    Id = 3, 
                    Nome = "Livros", 
                    IconCSS = "fas fa-book" 
                },
                new Categoria
                {
                    Id = 4,
                    Nome = "Esportes",
                    IconCSS = "fas fa-football-ball"
                },
                new Categoria
                {
                    Id = 5,
                    Nome = "Beleza",
                    IconCSS = "fas fa-magic"
                },
                new Categoria
                {
                    Id = 6,
                    Nome = "Alimentos",
                    IconCSS = "fas fa-utensils"
                },
                new Categoria
                {
                    Id = 7,
                    Nome = "Brinquedos",
                    IconCSS = "fas fa-puzzle-piece"
                },
                new Categoria
                {
                    Id = 8,
                    Nome = "Móveis",
                    IconCSS = "fas fa-couch"
                },
                new Categoria
                {
                    Id = 9,
                    Nome = "Saúde",
                    IconCSS = "fas fa-heartbeat"
                },
                new Categoria
                {
                    Id = 10,
                    Nome = "Automóveis",
                    IconCSS = "fas fa-car"
                },
                new Categoria
                {
                    Id = 11,
                    Nome = "Música",
                    IconCSS = "fas fa-music"
                },
                new Categoria
                {
                    Id = 12,
                    Nome = "Viagem",
                    IconCSS = "fas fa-plane"
                },
                new Categoria
                {
                    Id = 13,
                    Nome = "Casa e Jardim",
                    IconCSS = "fas fa-home"
                },
                new Categoria
                {
                    Id = 14,
                    Nome = "Tecnologia",
                    IconCSS = "fas fa-laptop"
                },
                new Categoria
                {
                    Id = 15,
                    Nome = "Fotografia",
                    IconCSS = "fas fa-camera"
                }

            );
            modelBuilder.Entity<Produto>().HasData( 
                new Produto { 
                    Id = 1, 
                    Nome = "Smartphone", 
                    Descricao = "Smartphone de última geração", 
                    ImagemUrl = "/Imagens/Smartphone/smartphone.png",
                    Preco = 1999.99m, 
                    CategoriaId = 1 
                },
                new Produto { 
                    Id = 2, 
                    Nome = "Camiseta", 
                    Descricao = "Camiseta de algodão", 
                    ImagemUrl = "/Imagens/Camiseta/camiseta.png",
                    Preco = 49.99m, 
                    CategoriaId = 2 
                },
                new Produto { 
                    Id = 3, 
                    Nome = "Livro", 
                    Descricao = "Livro de programação", 
                    ImagemUrl = "/Imagens/Livro/livro.png",
                    Preco = 79.99m, 
                    CategoriaId = 3 
                },
                new Produto
                {
                    Id = 4,
                    Nome = "Tênis de Corrida",
                    Descricao = "Tênis confortável para corrida",
                    ImagemUrl = "/Imagens/Tenis/tenis.png",
                    Preco = 299.99m,
                    CategoriaId = 4
                },
                new Produto
                {
                    Id = 5,
                    Nome = "Notebook",
                    Descricao = "Notebook de última geração",
                    ImagemUrl = "/Imagens/Notebook/notebook.png",
                    Preco = 3999.99m,
                    CategoriaId = 14
                },
                new Produto
                {
                    Id = 6,
                    Nome = "Câmera Fotográfica",
                    Descricao = "Câmera profissional para fotografia",
                    ImagemUrl = "/Imagens/Camara/camera.png",
                    Preco = 2499.99m,
                    CategoriaId = 15
                },
                new Produto
                {
                    Id = 7,
                    Nome = "Fone de Ouvido",
                    Descricao = "Fone de ouvido com cancelamento de ruído",
                    ImagemUrl = "/Imagens/Fone/fone.png",
                    Preco = 199.99m,
                    CategoriaId = 1
                },
                new Produto
                {
                    Id = 8,
                    Nome = "Relógio Inteligente",
                    Descricao = "Relógio com monitoramento de atividades físicas",
                    ImagemUrl = "/Imagens/Relogio/relogio.png",
                    Preco = 499.99m,
                    CategoriaId = 1
                },
                new Produto
                {
                    Id = 9,
                    Nome = "Cadeira Gamer",
                    Descricao = "Cadeira ergonômica para gamers",
                    ImagemUrl = "/Imagens/Cadeira/cadeira.png",
                    Preco = 899.99m,
                    CategoriaId = 8
                },
                new Produto
                {
                    Id = 10,
                    Nome = "Bicicleta",
                    Descricao = "Bicicleta para trilhas e passeios",
                    ImagemUrl = "/Imagens/Bicicleta/bicicleta.png",
                    Preco = 1499.99m,
                    CategoriaId = 4
                },
                new Produto
                {
                    Id = 11,
                    Nome = "Perfume",
                    Descricao = "Perfume importado de alta qualidade",
                    ImagemUrl = "/Imagens/Perfume/perfume.png",
                    Preco = 299.99m,
                    CategoriaId = 5
                },
                new Produto
                {
                    Id = 12,
                    Nome = "Cafeteira",
                    Descricao = "Cafeteira elétrica para café expresso",
                    ImagemUrl = "/Imagens/Cafeteira/cafeteira.png",
                    Preco = 249.99m,
                    CategoriaId = 6
                },
                new Produto
                {
                    Id = 13,
                    Nome = "Brinquedo Educativo",
                    Descricao = "Brinquedo que estimula o aprendizado",
                    ImagemUrl = "/Imagens/Brinquedo/brinquedo.png",
                    Preco = 79.99m,
                    CategoriaId = 7
                },
                new Produto
                {
                    Id = 14,
                    Nome = "Sofá",
                    Descricao = "Sofá confortável para sala de estar",
                    ImagemUrl = "/Imagens/Sofa/sofa.png",
                    Preco = 1999.99m,
                    CategoriaId = 8
                },
                new Produto
                {
                    Id = 15,
                    Nome = "Aspirador de Pó",
                    Descricao = "Aspirador potente para limpeza doméstica",
                    ImagemUrl = "/Imagens/Aspirador/aspirador.png",
                    Preco = 399.99m,
                    CategoriaId = 13
                },
                new Produto
                {
                    Id = 16,
                    Nome = "Guitarra Elétrica",
                    Descricao = "Guitarra de alta qualidade para músicos",
                    ImagemUrl = "/Imagens/Guitarra/guitarra.png",
                    Preco = 1499.99m,
                    CategoriaId = 11
                },
                new Produto
                {
                    Id = 17,
                    Nome = "Mochila de Viagem",
                    Descricao = "Mochila resistente para viagens e aventuras",
                    ImagemUrl = "/Imagens/Mochila/mochila.png",
                    Preco = 299.99m,
                    CategoriaId = 12
                },
                new Produto
                {
                    Id = 18,
                    Nome = "Tablet",
                    Descricao = "Tablet de última geração para entretenimento e produtividade",
                    ImagemUrl = "/Imagens/Tablet/tablet.png",
                    Preco = 1299.99m,
                    CategoriaId = 1
                },
                new Produto
                {
                    Id = 19,
                    Nome = "Livro de Ficção",
                    Descricao = "Livro envolvente de ficção para leitura prazerosa",
                    ImagemUrl = "/Imagens/LivroFiccao/livroficcao.png",
                    Preco = 59.99m,
                    CategoriaId = 3
                },
                new Produto
                {
                    Id = 20,
                    Nome = "Camiseta Estampada",
                    Descricao = "Camiseta com estampa moderna e estilosa",
                    ImagemUrl = "/Imagens/CamisetaEstampada/camisetaestampada.png",
                    Preco = 69.99m,
                    CategoriaId = 2
                }
            );
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    Id = 1,
                    NomeUsuario = "Gemilso"
                },
                new Usuario
                {
                    Id = 2,
                    NomeUsuario = "Gladis"
                },
                new Usuario
                {
                    Id = 3,
                    NomeUsuario = "Gustavo"
                },
                new Usuario
                {
                    Id = 4,
                    NomeUsuario = "Amalia"
                },
                new Usuario
                {
                    Id = 5,
                    NomeUsuario = "Neusa"
                }
            );
        }
    }
}