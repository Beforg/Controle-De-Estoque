using Controle_de_Estoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEstoque.Model
{
    public class Relatorio
    {
        public DateTime data { get; set; }
        public string codigo { get; set; }
        public int quantidade { get; set; }
        public string tipoOperacao { get; set; }

        public Relatorio() 
        {
        } 
    }
}
