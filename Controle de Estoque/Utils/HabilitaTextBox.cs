using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Estoque.Utils
{
    public class HabilitaTextBox
    {
        public static void HabilitarTextBox(TextBox tbCodigo, TextBox marca, TextBox modelo, TextBox descricao, bool status)
        { 
            marca.Enabled = status;
            modelo.Enabled = status;
            descricao.Enabled = status;
            tbCodigo.Enabled = !status;
        }
        public static void LimparTextBox(TextBox tbCodigo, TextBox marca, TextBox modelo, TextBox descricao)
        {
            tbCodigo.Text = "";
            marca.Text = "";
            modelo.Text = "";
            descricao.Text = "";
        }
        public static void HabilitaTextBoxControle(TextBox textbox, TextBox codigo, bool status)
        { 
            textbox.Enabled = status;
            codigo.Enabled = !status;
        }

        public static void LimpaTextBoxControle(TextBox textbox, TextBox codigo)
        {
            textbox.Text = "";
            codigo.Text = "";
        }
    }
}
