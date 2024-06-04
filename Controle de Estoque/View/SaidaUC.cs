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
using Controle_de_Estoque.Utils;
using Controle_de_Estoque.Model;
using BibliotecaEstoque.Model;

namespace Controle_de_Estoque.View
{
    public partial class SaidaUC : UserControl
    {
        public SaidaUC()
        {
            InitializeComponent();
        }

        private void SaidaUC_Load(object sender, EventArgs e)
        {
            tbCodigo.Focus();
        }
        public void FocusOnCodigo()
        {
            tbCodigo.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valido = Validacao.ValidaCodigo(tbCodigo);
            if (valido)
            {
                try
                {
                    ProdutoDB db = new ProdutoDB();
                    Produto produto = db.BuscarPorCodigo(tbCodigo.Text);
                    if (produto != null)
                    {
                        CarregaDadosPesquisa.CarregarDadosPesquisa(labelMarca, labelModelo, labelQtd, labelDescricao, produto);
                        HabilitaTextBox.HabilitaTextBoxControle(tbSaida, tbCodigo, true);
                        HabilitaButton.HabilitarButtonEntradaSaida(btCancelar, button2, true);
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar o produto:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            HabilitaTextBox.LimpaTextBoxControle(tbSaida, tbCodigo);
            HabilitaTextBox.HabilitaTextBoxControle(tbSaida, tbCodigo, false);
            CarregaDadosPesquisa.LimpaLabel(labelMarca, labelModelo, labelQtd, labelDescricao);
            tbCodigo.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool valido = Validacao.ValidaCampoEntradaSaida(tbSaida);

            if (valido)
            {
                ProdutoDB db = new ProdutoDB();
                Produto produto = db.BuscarPorCodigo(tbCodigo.Text);
                int qtdSaida = Convert.ToInt32(tbSaida.Text);
                bool validao = Validacao.ValidaSaida(produto.Quantidade, qtdSaida);


                if (!validao)
                {
                    return;
                }
                else
                {
                    int quantidadeTotalNova = produto.Quantidade - qtdSaida;
                    DialogResult dialogResult = MessageBox.Show("Deseja realmente dar saída no produto? \n A nova quantidade será de " + quantidadeTotalNova.ToString(), "Entrada", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {   
                        ProdutoDB dbRel = new ProdutoDB();
                        int quantidadeRestante = produto.Quantidade - qtdSaida;
                        string mensagem = db.SaidaProduto(produto, qtdSaida);
                        MessageBox.Show(mensagem + "\n Nova quantidade em estoque:" + quantidadeRestante.ToString(), "Operação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dbRel.AdicionarNoRelatorio(produto.Codigo, qtdSaida, DateTime.Now, TipoOperacao.Saida.ToString());
                        HabilitaTextBox.LimpaTextBoxControle(tbSaida, tbCodigo);
                        HabilitaTextBox.HabilitaTextBoxControle(tbSaida, tbCodigo, false);
                        CarregaDadosPesquisa.LimpaLabel(labelMarca, labelModelo, labelQtd, labelDescricao);
                        HabilitaButton.HabilitarButtonEntradaSaida(btCancelar, button2, false);
                    }
                    else
                    {
                        MessageBox.Show("Operação cancelada", "Operação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        private void tbSaida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void tbSaida_TextChanged(object sender, EventArgs e)
        {
            if (tbSaida.Text == "")
            {
                labelNovoEstoqueQtd.Visible = false;
                labelNovoEstoque.Visible = false;

            }
            else
            {
                labelNovoEstoqueQtd.Visible = true;
                labelNovoEstoque.Visible = true;
                int quantidadeAtual = Convert.ToInt32(labelQtd.Text);
                int quantidadeSaida = Convert.ToInt32(tbSaida.Text);

                int resultado = quantidadeAtual - quantidadeSaida;
                labelNovoEstoqueQtd.Text = resultado.ToString();
                if (resultado < 0)
                {
                    labelNovoEstoqueQtd.Text = resultado.ToString();
                    labelNovoEstoqueQtd.ForeColor = Color.Red;
                }
                else 
                {
                    labelNovoEstoqueQtd.Text = resultado.ToString();
                    labelNovoEstoqueQtd.ForeColor = Color.Black;
                }
            }
        }
    }
}
