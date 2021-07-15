using Projeto.UI_Produtos.Models;
using System.Collections.Generic;
using static Projeto.UI_Produtos.Repositories.ProdutoRepository;

namespace Projeto.UI_Produtos.Repositories
{
    public interface IProdutoRepository
    {
        IList<JoinProduto> GetProdutos();
        public void Save(Produto p);
        void Delete(int id);
        public Produto BuscaProduto(int id);
    }
}