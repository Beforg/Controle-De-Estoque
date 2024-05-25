using BibliotecaEstoque.Database;
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
    public partial class FormRemoverProduto : Form
    {
        public FormRemoverProduto()
        {
            InitializeComponent();
        }

        private void FormRemoverProduto_Load(object sender, EventArgs e)
        {
            CarregaDadosPesquisa.CarregaDadosParaLista(lvProdutos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lvProdutos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um produto para remover", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else 
            {
                DialogResult dialogResult = MessageBox.Show("Deseja realmente remover o produto? \n Essa ação NÃO pode ser desfeita.", "Remover Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    ListViewItem itemSelecionado = lvProdutos.SelectedItems[0];
                    string codigo = itemSelecionado.SubItems[1].Text;
                    ProdutoDB db = new ProdutoDB();
                    db.Remover(codigo);
                    MessageBox.Show("Produto removido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregaDadosPesquisa.CarregaDadosParaLista(lvProdutos);
                }
                else 
                {
                    MessageBox.Show("Operação cancelada", "Operação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }
    }
}
