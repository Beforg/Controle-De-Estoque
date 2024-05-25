using Controle_de_Estoque.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Estoque.Utils
{
    internal class TabFocus
    {
        public static void DarFocoAoTextBox(TabControl tabControl) { 
            int indiceCadastar = tabControl.TabPages.IndexOfKey("Cadastro de Produtos");
            int indicePesquisar = tabControl.TabPages.IndexOfKey("Pesquisar Produto");
            int indiceAlterar = tabControl.TabPages.IndexOfKey("Alterar Produto");
            int indiceEntrada = tabControl.TabPages.IndexOfKey("Entrada de Produto");
            int indiceSaida = tabControl.TabPages.IndexOfKey("Saída de Produto");
            
            if (tabControl.SelectedIndex == indiceCadastar) 
            {
                
                CadastroProdutoUC cadastroProdutoUC = tabControl.SelectedTab.Controls.OfType<CadastroProdutoUC>().FirstOrDefault();

                if(cadastroProdutoUC != null)
                {
                    cadastroProdutoUC.FocusOnCodigo();
                }
            }
            else if (tabControl.SelectedIndex == indiceEntrada)
            {
                
                EntradaUC entradaUC = tabControl.SelectedTab.Controls.OfType<EntradaUC>().FirstOrDefault();

                if (entradaUC != null)
                {
                    entradaUC.FocusOnCodigo();
                }
            }
            else if (tabControl.SelectedIndex == indiceSaida)
            {
                
                SaidaUC saidaUC = tabControl.SelectedTab.Controls.OfType<SaidaUC>().FirstOrDefault();

                if (saidaUC != null)
                {
                    saidaUC.FocusOnCodigo();
                }
            } else if (tabControl.SelectedIndex == indicePesquisar)
            {
                
                PesquisarProdutoUC pesquisarProdutoUC = tabControl.SelectedTab.Controls.OfType<PesquisarProdutoUC>().FirstOrDefault();

                if (pesquisarProdutoUC != null)
                {
                    pesquisarProdutoUC.FocusOnCodigo();
                }
            }
            else if (tabControl.SelectedIndex == indiceAlterar)
            {
                AlterarProdutoUC alterarProdutoUC = tabControl.SelectedTab.Controls.OfType<AlterarProdutoUC>().FirstOrDefault();

                if (alterarProdutoUC != null)
                {
                    alterarProdutoUC.FocusOnCodigo();
                }
            }
        }
    }
}
