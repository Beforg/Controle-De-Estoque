using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaEstoque.Database;
using BibliotecaEstoque.Model;

namespace Controle_de_Estoque.Utils
{
    public class CarregaDadosPesquisa
    {
        public static void CarregarDadosPesquisa(Label marca, Label modelo, Label qtd, Label descricao, Produto produto)
        {
            if (produto == null)
            {
                MessageBox.Show("Produto não encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            marca.Visible = true;
            modelo.Visible = true;
            qtd.Visible = true;
            descricao.Visible = true;
            try
            {
                marca.Text = produto.Marca;
                modelo.Text = produto.Modelo;
                qtd.Text = produto.Quantidade.ToString();
                descricao.Text = produto.Descricao;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados da pesquisa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CarregaDadosPesquisaTextBox(TextBox marca, TextBox modelo, TextBox descricao, Produto produto)
        {
            marca.Visible = true;
            modelo.Visible = true;
            descricao.Visible = true;
            if (produto == null)
            {
                MessageBox.Show("Produto não encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try { 
                marca.Text = produto.Marca;
                modelo.Text = produto.Modelo;
                descricao.Text = produto.Descricao;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados da pesquisa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public static void CarregaDadosParaLista(ListView listView) 
        {
            listView.Items.Clear();
            ProdutoDB db = new ProdutoDB();
            List<Produto> listProdutos = db.BuscarTodos();

            foreach (Produto produto in listProdutos) 
            {
                ListViewItem item = new ListViewItem(produto.Codigo + " | " + produto.Marca + " | " + produto.Modelo + " | Quantidade disponível: " + produto.Quantidade);

                item.SubItems.Add(produto.Codigo.ToString());
                item.SubItems.Add("Marca: " + produto.Marca);
                item.SubItems.Add("Quantidade em Estoque: " +produto.Quantidade.ToString());
                item.SubItems.Add("Descrição:" + produto.Descricao);

                
                listView.Items.Add(item);
            }
        }
        public static void LimpaLabel(Label marca, Label modelo, Label qtd, Label descricao)
        {
            marca.Visible = false;
            modelo.Visible = false;
            qtd.Visible = false;
            descricao.Visible = false;
        }
    }
}
