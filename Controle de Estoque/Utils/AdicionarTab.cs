using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Estoque.Utils
{
    internal class AdicionarTab
    {
        public static void AdicionarTabNoTabControl(TabControl tabControl, UserControl userControl, string nomeTab, int imageIndex)
        {
            TabPage tab = new TabPage();
            tab.Name = nomeTab;
            tab.Text = nomeTab;
            tab.Controls.Add(userControl);
            tab.ImageIndex = imageIndex;
            tabControl.TabPages.Add(tab);
        }
    }
}
