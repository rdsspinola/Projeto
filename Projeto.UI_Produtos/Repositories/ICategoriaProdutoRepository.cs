using Projeto.UI_Produtos.Models;
using System.Collections.Generic;

namespace Projeto.UI_Produtos.Repositories
{
    public interface ICategoriaProdutoRepository
    {
        public IList<CategoriaProduto> GetCategorias();
        public void CargaInicial();

    }
}