using BibliotecaEstoque.Database;
using Controle_de_Estoque.Utils.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaEstoque;
using Controle_de_Estoque.Utils;

namespace Controle_de_Estoque.View
{
    public partial class AlterarProdutoUC : UserControl
    {
        public AlterarProdutoUC()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formListaProdutos = new FormListaProdutos();
            formListaProdutos.ShowDialog();
        }

        private void AlterarProdutoUC_Load(object sender, EventArgs e)
        {
            tbCodigo.Focus();
        }
        public void FocusOnCodigo()
        {
            tbCodigo.Focus();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            bool valido = Validacao.Validar(tbCodigo, tbMarca, tbModelo);

            if (valido)
            {
                ProdutoDB db = new ProdutoDB();
                Produto produto = new Produto();

                produto.Codigo = Convert.ToString(tbCodigo.Text);
                produto.Marca = tbMarca.Text;
                produto.Modelo = tbModelo.Text;
                produto.Descricao = tbDescricao.Text;

                db.Atualizar(produto);
                MessageBox.Show("Produto atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HabilitaTextBox.HabilitarTextBox(tbCodigo, tbMarca, tbModelo, tbDescricao, false);
                HabilitaTextBox.LimparTextBox(tbCodigo, tbMarca, tbModelo, tbDescricao);
            }
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
                if (produto != null)
                {
                    HabilitaTextBox.HabilitarTextBox(tbCodigo, tbMarca, tbModelo, tbDescricao, true);
                    CarregaDadosPesquisa.CarregaDadosPesquisaTextBox(tbMarca, tbModelo, tbDescricao, produto);
                    HabilitaButton.HabilitarButtonAlterarProduto(btSalvar, Cancelar, true);
                }
                else
                {
                    MessageBox.Show("Produto não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar o produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            HabilitaTextBox.HabilitarTextBox(tbCodigo, tbMarca, tbModelo, tbDescricao, false);
            HabilitaTextBox.LimparTextBox(tbCodigo, tbMarca, tbModelo, tbDescricao);
            HabilitaButton.HabilitarButtonAlterarProduto(btSalvar, Cancelar, false);
        }

        private void AlterarProdutoUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
