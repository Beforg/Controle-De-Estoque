using BibliotecaEstoque.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle_de_Estoque.Utils;
using BibliotecaEstoque.Model;

namespace Controle_de_Estoque.View
{
    public partial class PesquisarProdutoUC : UserControl
    {
        public PesquisarProdutoUC()
        {
            InitializeComponent();
        }

        private void PesquisarProdutoUC_Load(object sender, EventArgs e)
        {
            tbCodigo.Focus();
        }
        public void FocusOnCodigo()
        {
            tbCodigo.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text == "")
            {
                MessageBox.Show("Digite um código para pesquisar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                ProdutoDB db = new ProdutoDB();
                Produto produto = db.BuscarPorCodigo(tbCodigo.Text);
                CarregaDadosPesquisa.CarregarDadosPesquisa(labelMarca, labelModelo, labelQtd, labelDescricao, produto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Produto não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formListaProdutos = new FormListaProdutos();
            formListaProdutos.ShowDialog();
        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            CarregaDadosPesquisa.LimpaLabel(labelMarca, labelModelo, labelQtd, labelDescricao);
            tbCodigo.Text = "";
            tbCodigo.Focus();
        }
    }
}
