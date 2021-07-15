using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Projeto.UI_Produtos.Models;
using Projeto.UI_Produtos.Repositories;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Projeto.UI_Produtos.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository produtoRepository;
        private readonly ICategoriaProdutoRepository categoriaProdutoRepository;

        public ProdutoController(IProdutoRepository produtoRepository, ICategoriaProdutoRepository categoriaProdutoRepository)
        {
            this.produtoRepository = produtoRepository;
            this.categoriaProdutoRepository = categoriaProdutoRepository;
        }

        // GET: ProdutoController
        public ActionResult Index()
        {
            ViewBag.produtos = produtoRepository.GetProdutos();
            ViewBag.categorias = new SelectList( categoriaProdutoRepository.GetCategorias(),"Id","Nome");
            return View();
        }

        [HttpPost]
        public string AddProduto([FromBody]TransporteProduto t) 
        {
            Produto p = new Produto()
            {
                Nome = t.nome,
                Descricao = t.descricao,
                Ativo = true,
                Perecivel = t.perecivel == "1" ? true : false,
                CategoriaID = int.Parse(t.categoria)
            };

            p.Id = t.id != "" ? int.Parse(t.id) : 0;

            produtoRepository.Save(p);

            return "{\"msg\":\"ok\"}";
        }

        [HttpPost]
        public string DeletaProduto([FromBody] TransporteProduto t)
        {
            produtoRepository.Delete(int.Parse(t.id));
            return "{\"msg\":\"ok\"}";
        }

        [HttpPost]
        public string BuscaProduto([FromBody] TransporteProduto t)
        {
            return JsonConvert.SerializeObject(produtoRepository.BuscaProduto(int.Parse(t.id)));
        }

    }

    public class TransporteProduto
    {
        public string id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public string categoria { get; set; }
        public string perecivel { get; set; }
    }
}
