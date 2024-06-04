using BibliotecaEstoque.Database;
using Controle_de_Estoque.Utils.Validation;
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
using Controle_de_Estoque.Model;
using BibliotecaEstoque.Model;

namespace Controle_de_Estoque.View
{
    public partial class EntradaUC : UserControl
    {
        public EntradaUC()
        {
            InitializeComponent();
        }

        private void EntradaUC_Load(object sender, EventArgs e)
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
                        HabilitaTextBox.HabilitaTextBoxControle(tbEntrada, tbCodigo, true);
                        HabilitaButton.HabilitarButtonEntradaSaida(button3, button2, true);
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar o produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HabilitaTextBox.LimpaTextBoxControle(tbEntrada, tbCodigo);
            HabilitaTextBox.HabilitaTextBoxControle(tbEntrada, tbCodigo, false);
            CarregaDadosPesquisa.LimpaLabel(labelMarca, labelModelo, labelQtd, labelDescricao);
            tbCodigo.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool valido = Validacao.ValidaCampoEntradaSaida(tbEntrada);

            if (valido)
            {

                ProdutoDB db = new ProdutoDB();
                Produto produto = db.BuscarPorCodigo(tbCodigo.Text);
                int qtdEntrada = Convert.ToInt32(tbEntrada.Text);

                int quantidadeTotalNova = produto.Quantidade + qtdEntrada;

                DialogResult dialogResult = MessageBox.Show("Deseja realmente dar entrada no produto? \n A nova quantidade será de " + quantidadeTotalNova.ToString(), "Entrada", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    ProdutoDB dbRel = new ProdutoDB();
                    string mensagem = db.EntrarProduto(produto, qtdEntrada);
                    dbRel.AdicionarNoRelatorio(produto.Codigo, qtdEntrada, DateTime.Now, TipoOperacao.Entrada.ToString());
                    MessageBox.Show(mensagem, "Operação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HabilitaTextBox.LimpaTextBoxControle(tbEntrada, tbCodigo);
                    HabilitaTextBox.HabilitaTextBoxControle(tbEntrada, tbCodigo, false);
                    CarregaDadosPesquisa.LimpaLabel(labelMarca, labelModelo, labelQtd, labelDescricao);
                    HabilitaButton.HabilitarButtonEntradaSaida(button3, button2, false);
                }
                else
                {
                    MessageBox.Show("Operação cancelada", "Operação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private void tbEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void labelDescricao_Click(object sender, EventArgs e)
        {

        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void tbEntrada_TextChanged(object sender, EventArgs e)
        {
            if (tbEntrada.Text == "")
            {
                labelNovoEstoqueQtd.Visible = false;
                labelNovoEstoque.Visible = false;

            }
            else 
            { 
                labelNovoEstoqueQtd.Visible = true;
                labelNovoEstoque.Visible = true;
                int quantidadeAtual = Convert.ToInt32(labelQtd.Text);
                int quantidadeEntrada = Convert.ToInt32(tbEntrada.Text);

                int resultado = quantidadeAtual + quantidadeEntrada;
                labelNovoEstoqueQtd.Text = resultado.ToString();
            }
            
        }
    }
}
