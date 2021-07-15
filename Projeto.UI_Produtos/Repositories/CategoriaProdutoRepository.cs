using Microsoft.EntityFrameworkCore;
using Projeto.UI_Produtos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.UI_Produtos.Repositories
{
    public class CategoriaProdutoRepository : ICategoriaProdutoRepository
    {
        private readonly ApplicationContext contexto;
        private readonly DbSet<CategoriaProduto> dbSet;

        public CategoriaProdutoRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
            dbSet = contexto.Set<CategoriaProduto>();
        }

        public IList<CategoriaProduto> GetCategorias()
        {
            return dbSet.ToList();
        }

        public void CargaInicial()
        {
            if (!dbSet.Where(p => p.Nome == "Eletrônico").Any())
            {
                dbSet.Add(new CategoriaProduto("Eletrônico", "Eletrodomésticos", true));
                contexto.SaveChanges();
            }

            if (!dbSet.Where(p => p.Nome == "Informática").Any())
            {
                dbSet.Add(new CategoriaProduto("Informática", "Produtos para Informática", true));
                contexto.SaveChanges();
            }

            if (!dbSet.Where(p => p.Nome == "Celulares").Any())
            {
                dbSet.Add(new CategoriaProduto("Celulares", "Aparelhos e acessórios", true));
                contexto.SaveChanges();
            }

            if (!dbSet.Where(p => p.Nome == "Moda").Any())
            {
                dbSet.Add(new CategoriaProduto("Moda", "Artigos para vestuário em geral", true));
                contexto.SaveChanges();
            }

            if (!dbSet.Where(p => p.Nome == "Livros").Any())
            {
                dbSet.Add(new CategoriaProduto("Livros", "Livros", true));
                contexto.SaveChanges();
            }
        }

    }
}
