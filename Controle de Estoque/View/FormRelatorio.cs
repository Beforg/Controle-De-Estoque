using Controle_de_Estoque.Service;
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
    public partial class FormRelatorio : Form
    {
        public FormRelatorio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregaDadosService.CarregaDadosParaDataGrid(dgvRelatorio, DateTime.Now);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CarregaDadosService.CarregaDadosParaDataGrid(dgvRelatorio, dtp.Value);
        }
    }
}
