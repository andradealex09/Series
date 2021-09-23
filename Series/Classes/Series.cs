using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
        public class Series : EntidadeBase
    {
        // Atributos

        private Genero Genero {get; set; }

        private string Titulo { get; set; }

        private string Descricao { get; set; }

        private int Ano { get; set; }

        private bool Excluido { get; set; }


        // Metodos

        public Series(int Id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = Id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
            
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Ínicio: " + this.Ano + Environment.NewLine;
            retorno += "Excluido" + this.Excluido;
            return retorno; 

        }

        public string retornaTitulo()
        {

            return this.Titulo;
        }

        public int retornaID()
        {
            return this.Id;
        }
        
        public void excluir()
        {
            this.Excluido = true;
        }
    }
}
