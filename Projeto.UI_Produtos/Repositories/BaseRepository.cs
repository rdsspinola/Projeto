using Microsoft.EntityFrameworkCore;
using Projeto.UI_Produtos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.UI_Produtos.Repositories
{
    public class BaseRepository<T> :BaseNode
    {
        private readonly ApplicationContext contexto;
        private readonly DbSet<T> dbSet;

        public BaseRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
            dbSet = contexto.Set<T>();
        }

    }
}
