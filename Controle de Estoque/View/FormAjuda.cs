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
    public partial class FormAjuda : Form
    {
        public FormAjuda()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                gbTexto.Text = "Cadastro de Produto | Ajuda";
                labelAjuda.Text =
                    "Para cadastrar um produto, vá até a aba 'Estoque -> Cadastrar Produto' e preencha os campos com as informações do produto. Após preencher os campos, clique no botão 'Cadastrar'." +
                    "\nO Código, Marca e Modelo são obrigatórios, sendo a Descrição e a Quantidade Inicial opcional, se não for informada a Quantidade Inicial, será atribuida 0. \nO Código é único e não poderá ser repetido.";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                gbTexto.Text = "Buscar Produto | Ajuda";
                labelAjuda.Text =
                    "Para buscar um produto, vá até a aba 'Estoque -> Buscar Produto' e selecione a opção 'Todos' ou 'Código', a opção 'Todos' vai listar todos os produtos cadastrados, na opção 'Código', preencha o campo 'Código' com o código do produto que deseja buscar. Após preencher o campo, clique no botão 'Buscar'." +
                    "\nSerá exibido as informações do produto, se o produto não for encontrado, será exibido uma mensagem informando que o produto não foi encontrado.";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                gbTexto.Text = "Alterar Produto | Ajuda";
                labelAjuda.Text =
                    "Para alterar um produto, vá até a aba 'Estoque -> Alterar Produto' e preencha o campo 'Código' com o código do produto que deseja alterar. Após preencher o campo, clique no botão 'Buscar'." +
                    "\nSerá recuperada as informações do produto, altere as informações que desejar e clique no botão 'Salvar'.";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                gbTexto.Text = "Remover Produto | Ajuda";
                labelAjuda.Text =
                    "Para remover um produto, vá até a aba 'Estoque -> Remover Produto' e selecione na lista o produto que deseja remover. Após selecionar o produto, clique no botão 'Remover'." +
                    "\nSerá exibido uma mensagem de confirmação, clique em 'Sim' para confirmar a remoção do produto ou 'Não' para cancelar a operação. a operação de Exclusão não pode ser desfeita e os dados apagados não podem ser recuperados.";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                gbTexto.Text = "Entrada de Produto | Ajuda";
                labelAjuda.Text =
                    "Para realizar a entrada de um produto, vá até a aba 'Controle -> Entrada' e preencha o campo 'Código' com o código do produto que deseja dar entrada. Após preencher o campo, clique no botão 'Buscar'." +
                    "\nSerá exibido as informações do produto, preencha o campo 'Entrada' com a quantidade que deseja dar entrada e clique no botão 'Registrar'.";
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                gbTexto.Text = "Saída de Produto | Ajuda";
                labelAjuda.Text =
                    "Para realizar a saída de um produto, vá até a aba 'Controle -> Saída' e preencha o campo 'Código' com o código do produto que deseja dar saída. Após preencher o campo, clique no botão 'Buscar'." +
                    "\nSerá exibido as informações do produto, preencha o campo 'Saída' com a quantidade que deseja dar saída e clique no botão 'Registrar'.";
            }
        }
    }
}
