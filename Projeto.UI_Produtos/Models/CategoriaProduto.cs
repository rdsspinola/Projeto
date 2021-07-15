using System.ComponentModel.DataAnnotations;

namespace Projeto.UI_Produtos.Models
{
    public class CategoriaProduto 
    {
        [Key()]
        public int Id { get;  set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public bool Ativo { get; set; }

        public CategoriaProduto(string nome, string descricao, bool ativo)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.Ativo = ativo;
        }
    }


}
