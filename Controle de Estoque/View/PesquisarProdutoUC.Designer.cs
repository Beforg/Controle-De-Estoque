namespace Controle_de_Estoque.View
{
    partial class PesquisarProdutoUC
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            tbCodigo = new TextBox();
            label2 = new Label();
            labelMarca = new Label();
            labelModelo = new Label();
            label5 = new Label();
            labelDescricao = new Label();
            label7 = new Label();
            labelQtd = new Label();
            label9 = new Label();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Location = new Point(18, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(638, 128);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesquisar Produto";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button2);
            groupBox4.Controls.Add(button1);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(tbCodigo);
            groupBox4.Location = new Point(15, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(606, 87);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(455, 46);
            button2.Name = "button2";
            button2.Size = new Size(112, 27);
            button2.TabIndex = 4;
            button2.Text = "Exibir todos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(319, 46);
            button1.Name = "button1";
            button1.Size = new Size(112, 27);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(76, 24);
            label1.TabIndex = 2;
            label1.Text = "Código";
            // 
            // tbCodigo
            // 
            tbCodigo.BorderStyle = BorderStyle.FixedSingle;
            tbCodigo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbCodigo.Location = new Point(6, 46);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(290, 29);
            tbCodigo.TabIndex = 3;
            tbCodigo.KeyPress += tbCodigo_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 28);
            label2.Name = "label2";
            label2.Size = new Size(69, 24);
            label2.TabIndex = 4;
            label2.Text = "Marca";
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMarca.Location = new Point(15, 59);
            labelMarca.MaximumSize = new Size(270, 0);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(39, 20);
            labelMarca.TabIndex = 5;
            labelMarca.Text = "label";
            labelMarca.Visible = false;
            // 
            // labelModelo
            // 
            labelModelo.AutoSize = true;
            labelModelo.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelModelo.Location = new Point(15, 141);
            labelModelo.MaximumSize = new Size(270, 0);
            labelModelo.Name = "labelModelo";
            labelModelo.Size = new Size(39, 20);
            labelModelo.TabIndex = 9;
            labelModelo.Text = "label";
            labelModelo.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 110);
            label5.Name = "label5";
            label5.Size = new Size(78, 24);
            label5.TabIndex = 8;
            label5.Text = "Modelo";
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelDescricao.Location = new Point(289, 59);
            labelDescricao.MaximumSize = new Size(270, 0);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(39, 20);
            labelDescricao.TabIndex = 11;
            labelDescricao.Text = "label";
            labelDescricao.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(289, 28);
            label7.Name = "label7";
            label7.Size = new Size(106, 24);
            label7.TabIndex = 10;
            label7.Text = "Descrição";
            // 
            // labelQtd
            // 
            labelQtd.AutoSize = true;
            labelQtd.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelQtd.Location = new Point(15, 228);
            labelQtd.MaximumSize = new Size(270, 0);
            labelQtd.Name = "labelQtd";
            labelQtd.Size = new Size(39, 20);
            labelQtd.TabIndex = 13;
            labelQtd.Text = "label";
            labelQtd.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(15, 197);
            label9.Name = "label9";
            label9.Size = new Size(234, 24);
            label9.TabIndex = 12;
            label9.Text = "Quantidade em Estoque";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelQtd);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(labelMarca);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(labelModelo);
            groupBox2.Controls.Add(labelDescricao);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(18, 171);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(638, 260);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Produto";
            // 
            // PesquisarProdutoUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "PesquisarProdutoUC";
            Size = new Size(676, 482);
            Load += PesquisarProdutoUC_Load;
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbCodigo;
        private Label label1;
        private Label label2;
        private Label labelMarca;
        private Label labelModelo;
        private Label label5;
        private Label labelDescricao;
        private Label label7;
        private Label labelQtd;
        private Label label9;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private Button button1;
        private Button button2;
    }
}
