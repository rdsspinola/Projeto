using Microsoft.EntityFrameworkCore;
using Projeto.UI_Produtos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.UI_Produtos
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Produto>().HasKey(k => k.Id);
            modelBuilder.Entity<CategoriaProduto>().HasKey(k => k.Id);
        }
    }
}
