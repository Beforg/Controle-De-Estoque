using Controle_de_Estoque.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Estoque.View
{
    public partial class FormListaProdutos : Form
    {
        public FormListaProdutos()
        {
            InitializeComponent();
        }

        private void FormListaProdutos_Load(object sender, EventArgs e)
        {
            CarregaDadosPesquisa.CarregaDadosParaLista(lvProdutos);
        }

        private void lvProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProdutos.SelectedItems.Count > 0)
            {
                ListViewItem itemSelecionado = lvProdutos.SelectedItems[0];
                string informacoes = "Código: " + itemSelecionado.SubItems[1].Text + " \n " + itemSelecionado.SubItems[2].Text + " \n " + itemSelecionado.SubItems[3].Text;
                MessageBox.Show(informacoes, "Informações do Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
