using Projeto.UI_Produtos.Models;
using Projeto.UI_Produtos.Repositories;

namespace Projeto.UI_Produtos
{
    class DataService : IDataService
    {
        private readonly ApplicationContext contexto;
        private readonly IProdutoRepository produtoRepository;
        private readonly ICategoriaProdutoRepository categoriaProdutoRepository;

        public DataService(ApplicationContext contexto, 
            IProdutoRepository produtoRepository,
            ICategoriaProdutoRepository categoriaProdutoRepository)
        {
            this.contexto = contexto;
            this.produtoRepository = produtoRepository;
            this.categoriaProdutoRepository = categoriaProdutoRepository;
        }

        public void InicializaDB()
        {
            contexto.Database.EnsureCreated();

            categoriaProdutoRepository.CargaInicial();

        }

    }
}
