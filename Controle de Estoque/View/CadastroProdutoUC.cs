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
using BibliotecaEstoque.Database;
using Controle_de_Estoque.Utils;

namespace Controle_de_Estoque.View
{
    public partial class CadastroProdutoUC : UserControl
    {
        public CadastroProdutoUC()
        {
            InitializeComponent();
        }

        private void CadastroProdutoUC_Load(object sender, EventArgs e)
        {
            tbCodigo.Focus();
        }

        public void FocusOnCodigo()
        {
            tbCodigo.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool valido = Validacao.Validar(tbCodigo, tbMarca, tbModelo);

            if (valido)
            {

                ProdutoDB produtoDB = new ProdutoDB();
                if (produtoDB.BuscarPorCodigo(tbCodigo.Text) != null)
                {
                    MessageBox.Show("Produto já cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (cbQuantidade.Checked)
                    {
                        string mes = produtoDB.Inserir("0", tbCodigo.Text, tbMarca.Text, tbModelo.Text, tbDescricao.Text, Convert.ToInt32(tbQuantidade.Text));
                    }
                    else
                    {
                        string mes = produtoDB.Inserir("0", tbCodigo.Text, tbMarca.Text, tbModelo.Text, tbDescricao.Text, 0);
                    }
                    MessageBox.Show("Produto cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbCodigo.Text = "";
                    tbMarca.Text = "";
                    tbModelo.Text = "";
                    tbDescricao.Text = "";
                    tbQuantidade.Text = "";
                    cbQuantidade.Checked = false;
                }

            }

        }

        private void groupBoxCadastroProduto_Enter(object sender, EventArgs e)
        {

        }

        private void cbQuantidade_CheckedChanged(object sender, EventArgs e)
        {
            if (cbQuantidade.Checked)
            {
                tbQuantidade.Enabled = true;
            }
            else
            {
                tbQuantidade.Enabled = false;
            }
        }

        private void tbQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            HabilitaTextBox.LimpaTextBoxCadastro(tbCodigo, tbMarca, tbModelo, tbDescricao);
            tbCodigo.Focus();
        }
    }
}
