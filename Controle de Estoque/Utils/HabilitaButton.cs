using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Estoque.Utils
{
    internal class HabilitaButton
    {
        public static void HabilitarButtonEntradaSaida(Button btn,Button btn2, bool status)
        {
            btn.Enabled = status;
            btn2.Enabled = status;
        }
        public static void HabilitarButtonAlterarProduto(Button bt1, Button bt2, bool status) 
        {
            bt1.Enabled = status;
            bt2.Enabled = status;
        }
    }
}
