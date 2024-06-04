namespace Controle_de_Estoque.View
{
    partial class FormRelatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtp = new DateTimePicker();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvRelatorio = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).BeginInit();
            SuspendLayout();
            // 
            // dtp
            // 
            dtp.Location = new Point(18, 59);
            dtp.Name = "dtp";
            dtp.Size = new Size(246, 23);
            dtp.TabIndex = 0;
            dtp.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtp);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(764, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Relatório de Estoque";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 30);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 1;
            label1.Text = "Seleicione o dia:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvRelatorio);
            groupBox2.Location = new Point(12, 130);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(764, 308);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registros";
            // 
            // dgvRelatorio
            // 
            dgvRelatorio.AllowUserToAddRows = false;
            dgvRelatorio.AllowUserToOrderColumns = true;
            dgvRelatorio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRelatorio.Dock = DockStyle.Fill;
            dgvRelatorio.Location = new Point(3, 19);
            dgvRelatorio.Name = "dgvRelatorio";
            dgvRelatorio.ReadOnly = true;
            dgvRelatorio.RowTemplate.Height = 25;
            dgvRelatorio.Size = new Size(758, 286);
            dgvRelatorio.TabIndex = 0;
            // 
            // FormRelatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormRelatorio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatório";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtp;
        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgvRelatorio;
    }
}