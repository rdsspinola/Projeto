using Projeto.UI_Produtos.Models;

namespace Projeto.UI_Produtos.Repositories
{
    public partial class ProdutoRepository
    {
        public class JoinProduto {
            public Produto Produto { get; set; }
            public string cNome { get; set; }
        }
    }
}
