using BibliotecaEstoque.Database;
using BibliotecaEstoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Estoque.Service
{
    public class CarregaDadosService
    {
        public static void CarregaDadosParaDataGrid(DataGridView dgv, DateTime data)
        { 
            dgv.Columns.Clear();
            ProdutoDB produtoDB = new ProdutoDB();
            List<Relatorio> relatorios = produtoDB.BuscarRelatorio(data);
            BindingSource source = new BindingSource();
            source.DataSource = relatorios;
            dgv.DataSource = source;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

           
            dgv.Columns["data"].HeaderText = "Data";
            dgv.Columns["codigo"].HeaderText = "Código do Produto";
            dgv.Columns["tipoOperacao"].HeaderText = "Tipo de Operação";
            dgv.Columns["quantidade"].HeaderText = "Quantidade";

        }
    }
}
