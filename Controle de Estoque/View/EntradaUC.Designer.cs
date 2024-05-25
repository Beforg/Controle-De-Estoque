namespace Controle_de_Estoque.View
{
    partial class EntradaUC
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
            button1 = new Button();
            tbCodigo = new TextBox();
            label1 = new Label();
            labelQtd = new Label();
            label10 = new Label();
            labelDescricao = new Label();
            label8 = new Label();
            labelModelo = new Label();
            label6 = new Label();
            button2 = new Button();
            tbEntrada = new TextBox();
            label4 = new Label();
            labelMarca = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            groupBox3 = new GroupBox();
            labelNovoEstoqueQtd = new Label();
            labelNovoEstoque = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(tbCodigo);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(649, 123);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registrar entrada de produto";
            // 
            // button1
            // 
            button1.Location = new Point(522, 59);
            button1.Name = "button1";
            button1.Size = new Size(112, 27);
            button1.TabIndex = 6;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbCodigo
            // 
            tbCodigo.BorderStyle = BorderStyle.FixedSingle;
            tbCodigo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbCodigo.Location = new Point(18, 59);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(496, 29);
            tbCodigo.TabIndex = 3;
            tbCodigo.KeyPress += tbCodigo_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 32);
            label1.Name = "label1";
            label1.Size = new Size(76, 24);
            label1.TabIndex = 2;
            label1.Text = "Código";
            // 
            // labelQtd
            // 
            labelQtd.AutoSize = true;
            labelQtd.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelQtd.Location = new Point(277, 140);
            labelQtd.Name = "labelQtd";
            labelQtd.Size = new Size(92, 20);
            labelQtd.TabIndex = 15;
            labelQtd.Text = "uni_estoques";
            labelQtd.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(19, 136);
            label10.Name = "label10";
            label10.Size = new Size(238, 24);
            label10.TabIndex = 14;
            label10.Text = "Quantidade em estoque:";
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelDescricao.Location = new Point(451, 63);
            labelDescricao.MaximumSize = new Size(150, 0);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(96, 20);
            labelDescricao.TabIndex = 13;
            labelDescricao.Text = "uni_estoques ";
            labelDescricao.Visible = false;
            labelDescricao.Click += labelDescricao_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(451, 28);
            label8.Name = "label8";
            label8.Size = new Size(112, 24);
            label8.TabIndex = 12;
            label8.Text = "Descrição:";
            // 
            // labelModelo
            // 
            labelModelo.AutoSize = true;
            labelModelo.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelModelo.Location = new Point(109, 87);
            labelModelo.Name = "labelModelo";
            labelModelo.Size = new Size(92, 20);
            labelModelo.TabIndex = 11;
            labelModelo.Text = "uni_estoques";
            labelModelo.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(19, 83);
            label6.Name = "label6";
            label6.Size = new Size(84, 24);
            label6.TabIndex = 10;
            label6.Text = "Modelo:";
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(522, 85);
            button2.Name = "button2";
            button2.Size = new Size(112, 27);
            button2.TabIndex = 9;
            button2.Text = "Registrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tbEntrada
            // 
            tbEntrada.BorderStyle = BorderStyle.FixedSingle;
            tbEntrada.Enabled = false;
            tbEntrada.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbEntrada.Location = new Point(11, 73);
            tbEntrada.Name = "tbEntrada";
            tbEntrada.Size = new Size(122, 29);
            tbEntrada.TabIndex = 8;
            tbEntrada.TextAlign = HorizontalAlignment.Center;
            tbEntrada.TextChanged += tbEntrada_TextChanged;
            tbEntrada.KeyPress += tbEntrada_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(11, 33);
            label4.Name = "label4";
            label4.Size = new Size(89, 24);
            label4.TabIndex = 7;
            label4.Text = "Entrada:";
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMarca.Location = new Point(109, 32);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(92, 20);
            labelMarca.TabIndex = 5;
            labelMarca.Text = "uni_estoques";
            labelMarca.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 28);
            label2.Name = "label2";
            label2.Size = new Size(75, 24);
            label2.TabIndex = 4;
            label2.Text = "Marca:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelQtd);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(labelMarca);
            groupBox2.Controls.Add(labelDescricao);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(labelModelo);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(12, 144);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(649, 184);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informações do Produto";
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(402, 85);
            button3.Name = "button3";
            button3.Size = new Size(112, 27);
            button3.TabIndex = 16;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(labelNovoEstoqueQtd);
            groupBox3.Controls.Add(labelNovoEstoque);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(tbEntrada);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(12, 334);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(649, 132);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Entrada";
            // 
            // labelNovoEstoqueQtd
            // 
            labelNovoEstoqueQtd.AutoSize = true;
            labelNovoEstoqueQtd.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNovoEstoqueQtd.Location = new Point(158, 77);
            labelNovoEstoqueQtd.Name = "labelNovoEstoqueQtd";
            labelNovoEstoqueQtd.Size = new Size(114, 23);
            labelNovoEstoqueQtd.TabIndex = 18;
            labelNovoEstoqueQtd.Text = "uni_estoques";
            labelNovoEstoqueQtd.Visible = false;
            // 
            // labelNovoEstoque
            // 
            labelNovoEstoque.AutoSize = true;
            labelNovoEstoque.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelNovoEstoque.Location = new Point(158, 33);
            labelNovoEstoque.Name = "labelNovoEstoque";
            labelNovoEstoque.Size = new Size(146, 24);
            labelNovoEstoque.TabIndex = 17;
            labelNovoEstoque.Text = "Novo estoque:";
            labelNovoEstoque.Visible = false;
            // 
            // EntradaUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "EntradaUC";
            Size = new Size(676, 482);
            Load += EntradaUC_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelMarca;
        private Label label2;
        private TextBox tbCodigo;
        private Label label1;
        private Button button2;
        private TextBox tbEntrada;
        private Label label4;
        private Button button1;
        private Label labelQtd;
        private Label label10;
        private Label labelDescricao;
        private Label label8;
        private Label labelModelo;
        private Label label6;
        private GroupBox groupBox2;
        private Button button3;
        private GroupBox groupBox3;
        private Label labelNovoEstoqueQtd;
        private Label labelNovoEstoque;
    }
}
