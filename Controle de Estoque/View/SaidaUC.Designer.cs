namespace Controle_de_Estoque.View
{
    partial class SaidaUC
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
            tbSaida = new TextBox();
            label4 = new Label();
            labelMarca = new Label();
            label2 = new Label();
            button2 = new Button();
            groupBox2 = new GroupBox();
            btCancelar = new Button();
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
            groupBox1.Location = new Point(14, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(649, 123);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registrar saída de produto";
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
            labelQtd.MaximumSize = new Size(250, 0);
            labelQtd.Name = "labelQtd";
            labelQtd.Size = new Size(85, 20);
            labelQtd.TabIndex = 25;
            labelQtd.Text = "uni_estoque";
            labelQtd.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(19, 136);
            label10.Name = "label10";
            label10.Size = new Size(238, 24);
            label10.TabIndex = 24;
            label10.Text = "Quantidade em estoque:";
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelDescricao.Location = new Point(451, 63);
            labelDescricao.MaximumSize = new Size(200, 0);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(85, 20);
            labelDescricao.TabIndex = 23;
            labelDescricao.Text = "uni_estoque";
            labelDescricao.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(451, 28);
            label8.Name = "label8";
            label8.Size = new Size(112, 24);
            label8.TabIndex = 22;
            label8.Text = "Descrição:";
            // 
            // labelModelo
            // 
            labelModelo.AutoSize = true;
            labelModelo.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelModelo.Location = new Point(99, 89);
            labelModelo.MaximumSize = new Size(250, 0);
            labelModelo.Name = "labelModelo";
            labelModelo.Size = new Size(85, 20);
            labelModelo.TabIndex = 21;
            labelModelo.Text = "uni_estoque";
            labelModelo.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(19, 85);
            label6.Name = "label6";
            label6.Size = new Size(84, 24);
            label6.TabIndex = 20;
            label6.Text = "Modelo:";
            // 
            // tbSaida
            // 
            tbSaida.BorderStyle = BorderStyle.FixedSingle;
            tbSaida.Enabled = false;
            tbSaida.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbSaida.Location = new Point(11, 73);
            tbSaida.Name = "tbSaida";
            tbSaida.Size = new Size(122, 29);
            tbSaida.TabIndex = 19;
            tbSaida.TextAlign = HorizontalAlignment.Center;
            tbSaida.TextChanged += tbSaida_TextChanged;
            tbSaida.KeyPress += tbSaida_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(11, 33);
            label4.Name = "label4";
            label4.Size = new Size(71, 24);
            label4.TabIndex = 18;
            label4.Text = "Saída:";
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMarca.Location = new Point(94, 34);
            labelMarca.MaximumSize = new Size(250, 0);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(85, 20);
            labelMarca.TabIndex = 17;
            labelMarca.Text = "uni_estoque";
            labelMarca.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 30);
            label2.Name = "label2";
            label2.Size = new Size(75, 24);
            label2.TabIndex = 16;
            label2.Text = "Marca:";
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
            // groupBox2
            // 
            groupBox2.Controls.Add(labelQtd);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(labelDescricao);
            groupBox2.Controls.Add(labelMarca);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(labelModelo);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(14, 144);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(649, 184);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informações do Produto";
            // 
            // btCancelar
            // 
            btCancelar.Enabled = false;
            btCancelar.Location = new Point(402, 85);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(112, 27);
            btCancelar.TabIndex = 26;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(labelNovoEstoqueQtd);
            groupBox3.Controls.Add(labelNovoEstoque);
            groupBox3.Controls.Add(btCancelar);
            groupBox3.Controls.Add(tbSaida);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(button2);
            groupBox3.Location = new Point(14, 338);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(649, 132);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Saída";
            // 
            // labelNovoEstoqueQtd
            // 
            labelNovoEstoqueQtd.AutoSize = true;
            labelNovoEstoqueQtd.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNovoEstoqueQtd.Location = new Point(163, 77);
            labelNovoEstoqueQtd.Name = "labelNovoEstoqueQtd";
            labelNovoEstoqueQtd.Size = new Size(114, 23);
            labelNovoEstoqueQtd.TabIndex = 28;
            labelNovoEstoqueQtd.Text = "uni_estoques";
            labelNovoEstoqueQtd.Visible = false;
            // 
            // labelNovoEstoque
            // 
            labelNovoEstoque.AutoSize = true;
            labelNovoEstoque.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelNovoEstoque.Location = new Point(163, 33);
            labelNovoEstoque.Name = "labelNovoEstoque";
            labelNovoEstoque.Size = new Size(146, 24);
            labelNovoEstoque.TabIndex = 27;
            labelNovoEstoque.Text = "Novo estoque:";
            labelNovoEstoque.Visible = false;
            // 
            // SaidaUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "SaidaUC";
            Size = new Size(676, 482);
            Load += SaidaUC_Load;
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
        private Button button2;
        private Button button1;
        private TextBox tbCodigo;
        private Label label1;
        private Label labelQtd;
        private Label label10;
        private Label labelDescricao;
        private Label label8;
        private Label labelModelo;
        private Label label6;
        private TextBox tbSaida;
        private Label label4;
        private Label labelMarca;
        private Label label2;
        private GroupBox groupBox2;
        private Button btCancelar;
        private GroupBox groupBox3;
        private Label labelNovoEstoqueQtd;
        private Label labelNovoEstoque;
    }
}
