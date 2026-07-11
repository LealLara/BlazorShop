using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorShop.Api.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IconCSS = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeUsuario = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ImagemUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carrinhos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrinhos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carrinhos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarrinhoItens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarrinhoId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoItens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarrinhoItens_Carrinhos_CarrinhoId",
                        column: x => x.CarrinhoId,
                        principalTable: "Carrinhos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarrinhoItens_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "IconCSS", "Nome" },
                values: new object[,]
                {
                    { 1, "fas fa-tv", "Eletrônicos" },
                    { 2, "fas fa-tshirt", "Roupas" },
                    { 3, "fas fa-book", "Livros" },
                    { 4, "fas fa-football-ball", "Esportes" },
                    { 5, "fas fa-magic", "Beleza" },
                    { 6, "fas fa-utensils", "Alimentos" },
                    { 7, "fas fa-puzzle-piece", "Brinquedos" },
                    { 8, "fas fa-couch", "Móveis" },
                    { 9, "fas fa-heartbeat", "Saúde" },
                    { 10, "fas fa-car", "Automóveis" },
                    { 11, "fas fa-music", "Música" },
                    { 12, "fas fa-plane", "Viagem" },
                    { 13, "fas fa-home", "Casa e Jardim" },
                    { 14, "fas fa-laptop", "Tecnologia" },
                    { 15, "fas fa-camera", "Fotografia" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "NomeUsuario" },
                values: new object[,]
                {
                    { 1, "Gemilso" },
                    { 2, "Gladis" },
                    { 3, "Gustavo" },
                    { 4, "Amalia" },
                    { 5, "Neusa" }
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "CategoriaId", "Descricao", "ImagemUrl", "Nome", "Preco", "Quantidade" },
                values: new object[,]
                {
                    { 1, 1, "Smartphone de última geração", "/Imagens/Smartphone/smartphone.png", "Smartphone", 1999.99m, 0 },
                    { 2, 2, "Camiseta de algodão", "/Imagens/Camiseta/camiseta.png", "Camiseta", 49.99m, 0 },
                    { 3, 3, "Livro de programação", "/Imagens/Livro/livro.png", "Livro", 79.99m, 0 },
                    { 4, 4, "Tênis confortável para corrida", "/Imagens/Tenis/tenis.png", "Tênis de Corrida", 299.99m, 0 },
                    { 5, 14, "Notebook de última geração", "/Imagens/Notebook/notebook.png", "Notebook", 3999.99m, 0 },
                    { 6, 15, "Câmera profissional para fotografia", "/Imagens/Camara/camera.png", "Câmera Fotográfica", 2499.99m, 0 },
                    { 7, 1, "Fone de ouvido com cancelamento de ruído", "/Imagens/Fone/fone.png", "Fone de Ouvido", 199.99m, 0 },
                    { 8, 1, "Relógio com monitoramento de atividades físicas", "/Imagens/Relogio/relogio.png", "Relógio Inteligente", 499.99m, 0 },
                    { 9, 8, "Cadeira ergonômica para gamers", "/Imagens/Cadeira/cadeira.png", "Cadeira Gamer", 899.99m, 0 },
                    { 10, 4, "Bicicleta para trilhas e passeios", "/Imagens/Bicicleta/bicicleta.png", "Bicicleta", 1499.99m, 0 },
                    { 11, 5, "Perfume importado de alta qualidade", "/Imagens/Perfume/perfume.png", "Perfume", 299.99m, 0 },
                    { 12, 6, "Cafeteira elétrica para café expresso", "/Imagens/Cafeteira/cafeteira.png", "Cafeteira", 249.99m, 0 },
                    { 13, 7, "Brinquedo que estimula o aprendizado", "/Imagens/Brinquedo/brinquedo.png", "Brinquedo Educativo", 79.99m, 0 },
                    { 14, 8, "Sofá confortável para sala de estar", "/Imagens/Sofa/sofa.png", "Sofá", 1999.99m, 0 },
                    { 15, 13, "Aspirador potente para limpeza doméstica", "/Imagens/Aspirador/aspirador.png", "Aspirador de Pó", 399.99m, 0 },
                    { 16, 11, "Guitarra de alta qualidade para músicos", "/Imagens/Guitarra/guitarra.png", "Guitarra Elétrica", 1499.99m, 0 },
                    { 17, 12, "Mochila resistente para viagens e aventuras", "/Imagens/Mochila/mochila.png", "Mochila de Viagem", 299.99m, 0 },
                    { 18, 1, "Tablet de última geração para entretenimento e produtividade", "/Imagens/Tablet/tablet.png", "Tablet", 1299.99m, 0 },
                    { 19, 3, "Livro envolvente de ficção para leitura prazerosa", "/Imagens/LivroFiccao/livroficcao.png", "Livro de Ficção", 59.99m, 0 },
                    { 20, 2, "Camiseta com estampa moderna e estilosa", "/Imagens/CamisetaEstampada/camisetaestampada.png", "Camiseta Estampada", 69.99m, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoItens_CarrinhoId",
                table: "CarrinhoItens",
                column: "CarrinhoId");

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoItens_ProdutoId",
                table: "CarrinhoItens",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Carrinhos_UsuarioId",
                table: "Carrinhos",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CategoriaId",
                table: "Produtos",
                column: "CategoriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarrinhoItens");

            migrationBuilder.DropTable(
                name: "Carrinhos");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
