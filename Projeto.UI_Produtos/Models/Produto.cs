using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Projeto.UI_Produtos.Models
{
    [DataContract]
    public class Produto 
    {
        [Key()]
        [DataMember]
        public int Id { get;  set; }
        [Required]
        [DataMember]
        public string Nome { get;  set; }
        [Required]
        [DataMember]
        public string Descricao { get;  set; }
        [Required]
        [DataMember]
        public bool Ativo { get;  set; }
        [Required]
        [DataMember]
        public bool Perecivel { get;  set; }
        [ForeignKey("CategoriaProduto")]
        [DataMember]
        public int CategoriaID { get;  set; }
        public virtual CategoriaProduto CategoriaProduto { get;  set; }


        public void Salvar() { 
            //var db = new ApplicationContext();
        }

        public Produto() { }

        public Produto(string nome, string descricao, bool ativo, bool perecivel, CategoriaProduto categoriaid)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.Ativo = ativo;
            this.Perecivel = perecivel;
            //this.CategoriaID = categoriaid;
        }
    }
}
