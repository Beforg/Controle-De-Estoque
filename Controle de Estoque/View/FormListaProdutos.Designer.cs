namespace Controle_de_Estoque.View
{
    partial class FormListaProdutos
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
            groupBox1 = new GroupBox();
            lvProdutos = new ListView();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(lvProdutos);
            groupBox1.Location = new Point(12, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(756, 436);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de produtos cadastrados";
            // 
            // lvProdutos
            // 
            lvProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvProdutos.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lvProdutos.GridLines = true;
            lvProdutos.LabelWrap = false;
            lvProdutos.Location = new Point(3, 19);
            lvProdutos.Name = "lvProdutos";
            lvProdutos.Size = new Size(750, 414);
            lvProdutos.TabIndex = 0;
            lvProdutos.UseCompatibleStateImageBehavior = false;
            lvProdutos.View = System.Windows.Forms.View.List;
            lvProdutos.SelectedIndexChanged += lvProdutos_SelectedIndexChanged;
            // 
            // FormListaProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 464);
            Controls.Add(groupBox1);
            Name = "FormListaProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar";
            Load += FormListaProdutos_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ListView lvProdutos;
        public GroupBox groupBox1;
    }
}