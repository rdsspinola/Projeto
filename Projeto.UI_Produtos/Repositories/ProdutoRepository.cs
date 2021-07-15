using Projeto.UI_Produtos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.UI_Produtos.Repositories
{
    public partial class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationContext contexto;

        public ProdutoRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
        }

        public void Delete(int id)
        {
            Produto p = new Produto() {Id = id };
            contexto.Set<Produto>().Attach(p);
            contexto.Set<Produto>().Remove(p);
            contexto.SaveChanges();
        }

        public IList<JoinProduto> GetProdutos()
        {
            var produtos = (from p in contexto.Set<Produto>()
                              join c in contexto.Set<CategoriaProduto>() on p.CategoriaID equals c.Id
                              where p.Ativo == true
                              select new JoinProduto()
                              {
                                  Produto = p,
                                  cNome = c.Nome,
                              }).ToList();

            return produtos;
        }

        public void Save(Produto p)
        {
            if (p.Id == 0)
            {
                contexto.Set<Produto>().Add(p);
            }
            else 
            {
                contexto.Set<Produto>().Update(p);
            }

            contexto.SaveChanges();
        }

        public Produto BuscaProduto(int id) 
        {
            return contexto.Set<Produto>().Where(p => p.Id == id).FirstOrDefault();
        }
    }
}
