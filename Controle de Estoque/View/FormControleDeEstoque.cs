using Controle_de_Estoque.View;
using Controle_de_Estoque.Utils;

namespace Controle_de_Estoque
{
    public partial class FormControleDeEstoque : Form
    {
        bool isFormCadastrrProdutoOpen = false;
        bool isFormPesquisarProdutoOpen = false;
        bool isFormAlterarProdutoOpen = false;
        bool isFormEntradaOpen = false;
        bool isFormSaidaOpen = false;

        public FormControleDeEstoque()
        {
            InitializeComponent();
        }

        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isFormCadastrrProdutoOpen)
            {
                AdicionarTab.AdicionarTabNoTabControl(tabControlEstoque, new CadastroProdutoUC(), "Cadastro de Produtos", 6);
                isFormCadastrrProdutoOpen = true;
            }
            else
            {
                MessageBox.Show("Já existe uma aba de Cadastro aberta", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isFormPesquisarProdutoOpen)
            {
                AdicionarTab.AdicionarTabNoTabControl(tabControlEstoque, new PesquisarProdutoUC(), "Pesquisar Produto", 0);
                isFormPesquisarProdutoOpen = true;
            }
            else
            {
                MessageBox.Show("Já existe uma aba de Pesquisa aberta", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formListar = new FormListaProdutos();
            formListar.ShowDialog();
        }

        private void alterarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isFormAlterarProdutoOpen)
            {
                AdicionarTab.AdicionarTabNoTabControl(tabControlEstoque, new AlterarProdutoUC(), "Alterar Produto", 4);
                isFormAlterarProdutoOpen = true;
            }
            else
            {
                MessageBox.Show("Já existe uma aba de Edição aberta", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isFormEntradaOpen)
            {
                AdicionarTab.AdicionarTabNoTabControl(tabControlEstoque, new EntradaUC(), "Entrada de Produto", 2);
                isFormEntradaOpen = true;
            }
            else
            {
                MessageBox.Show("Já existe uma aba de Entrada aberta", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void saídaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isFormSaidaOpen)
            {
                AdicionarTab.AdicionarTabNoTabControl(tabControlEstoque, new SaidaUC(), "Saída de Produto", 1);
                isFormSaidaOpen = true;
            }
            else
            {
                MessageBox.Show("Já existe uma aba de Saída aberta", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabControlEstoque_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void tabControlEstoque_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabFocus.DarFocoAoTextBox(tabControlEstoque);
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("versão 1.0.1 \n 2024 Bruno Forgiarini \n github/Beforg \n MS Visual Studio 2022", "Sobre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void removerProdutoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form formRemover = new FormRemoverProduto();
            formRemover.ShowDialog();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formAjuda = new FormAjuda();
            formAjuda.ShowDialog();
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorio formRelatorio = new FormRelatorio();
            formRelatorio.ShowDialog();
        }
    }
}
