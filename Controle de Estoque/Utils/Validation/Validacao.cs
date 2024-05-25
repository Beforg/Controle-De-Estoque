using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Estoque.Utils.Validation
{
    internal class Validacao
    {
        public static bool Validar(TextBox codigo, TextBox marca, TextBox modelo) {
            if (codigo.Text == "" || marca.Text == "" || modelo.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        } 
        public static bool ValidaCodigo(TextBox codigo)
        {
            if (codigo.Text == "")
            {
                MessageBox.Show("Digite um código para pesquisar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool ValidaCampoEntradaSaida(TextBox textBox) 
        {
            int valorConvertido = Convert.ToInt32(textBox.Text);
            if (textBox.Text == "" || valorConvertido < 0)
            {
                MessageBox.Show("Digite um valor válido para entrada/saída", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static bool ValidaSaida(int qtdEstoque, int qtdSaida) 
        {
            if(qtdSaida > qtdEstoque)
            {
                MessageBox.Show("Quantidade de saída maior que a quantidade em estoque", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
