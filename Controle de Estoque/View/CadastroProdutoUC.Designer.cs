namespace Controle_de_Estoque.View
{
    partial class CadastroProdutoUC
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
            groupBoxCadastroProduto = new GroupBox();
            btCancelar = new Button();
            tbQuantidade = new TextBox();
            cbQuantidade = new CheckBox();
            button2 = new Button();
            tbDescricao = new TextBox();
            label4 = new Label();
            tbModelo = new TextBox();
            label3 = new Label();
            tbMarca = new TextBox();
            label2 = new Label();
            tbCodigo = new TextBox();
            label1 = new Label();
            groupBoxCadastroProduto.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCadastroProduto
            // 
            groupBoxCadastroProduto.Controls.Add(btCancelar);
            groupBoxCadastroProduto.Controls.Add(tbQuantidade);
            groupBoxCadastroProduto.Controls.Add(cbQuantidade);
            groupBoxCadastroProduto.Controls.Add(button2);
            groupBoxCadastroProduto.Controls.Add(tbDescricao);
            groupBoxCadastroProduto.Controls.Add(label4);
            groupBoxCadastroProduto.Controls.Add(tbModelo);
            groupBoxCadastroProduto.Controls.Add(label3);
            groupBoxCadastroProduto.Controls.Add(tbMarca);
            groupBoxCadastroProduto.Controls.Add(label2);
            groupBoxCadastroProduto.Controls.Add(tbCodigo);
            groupBoxCadastroProduto.Controls.Add(label1);
            groupBoxCadastroProduto.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxCadastroProduto.Location = new Point(9, 9);
            groupBoxCadastroProduto.Name = "groupBoxCadastroProduto";
            groupBoxCadastroProduto.Size = new Size(657, 464);
            groupBoxCadastroProduto.TabIndex = 0;
            groupBoxCadastroProduto.TabStop = false;
            groupBoxCadastroProduto.Text = "Cadastro de Produtos";
            groupBoxCadastroProduto.Enter += groupBoxCadastroProduto_Enter;
            // 
            // btCancelar
            // 
            btCancelar.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btCancelar.Location = new Point(386, 413);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(117, 30);
            btCancelar.TabIndex = 12;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // tbQuantidade
            // 
            tbQuantidade.BorderStyle = BorderStyle.FixedSingle;
            tbQuantidade.Enabled = false;
            tbQuantidade.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbQuantidade.Location = new Point(205, 406);
            tbQuantidade.Name = "tbQuantidade";
            tbQuantidade.Size = new Size(137, 29);
            tbQuantidade.TabIndex = 11;
            tbQuantidade.TextAlign = HorizontalAlignment.Center;
            tbQuantidade.KeyPress += tbQuantidade_KeyPress;
            // 
            // cbQuantidade
            // 
            cbQuantidade.AutoSize = true;
            cbQuantidade.Location = new Point(22, 413);
            cbQuantidade.Name = "cbQuantidade";
            cbQuantidade.Size = new Size(177, 19);
            cbQuantidade.TabIndex = 10;
            cbQuantidade.Text = "Adicionar quantidade inicial";
            cbQuantidade.UseVisualStyleBackColor = true;
            cbQuantidade.CheckedChanged += cbQuantidade_CheckedChanged;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(509, 413);
            button2.Name = "button2";
            button2.Size = new Size(117, 30);
            button2.TabIndex = 9;
            button2.Text = "Cadastrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tbDescricao
            // 
            tbDescricao.BorderStyle = BorderStyle.FixedSingle;
            tbDescricao.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbDescricao.Location = new Point(21, 289);
            tbDescricao.Multiline = true;
            tbDescricao.Name = "tbDescricao";
            tbDescricao.Size = new Size(605, 97);
            tbDescricao.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 262);
            label4.Name = "label4";
            label4.Size = new Size(106, 24);
            label4.TabIndex = 6;
            label4.Text = "Descrição";
            // 
            // tbModelo
            // 
            tbModelo.BorderStyle = BorderStyle.FixedSingle;
            tbModelo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbModelo.Location = new Point(21, 219);
            tbModelo.Name = "tbModelo";
            tbModelo.Size = new Size(605, 29);
            tbModelo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 192);
            label3.Name = "label3";
            label3.Size = new Size(86, 24);
            label3.TabIndex = 4;
            label3.Text = "Modelo*";
            // 
            // tbMarca
            // 
            tbMarca.BorderStyle = BorderStyle.FixedSingle;
            tbMarca.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbMarca.Location = new Point(21, 141);
            tbMarca.Name = "tbMarca";
            tbMarca.Size = new Size(605, 29);
            tbMarca.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 114);
            label2.Name = "label2";
            label2.Size = new Size(77, 24);
            label2.TabIndex = 2;
            label2.Text = "Marca*";
            // 
            // tbCodigo
            // 
            tbCodigo.BorderStyle = BorderStyle.FixedSingle;
            tbCodigo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbCodigo.Location = new Point(21, 62);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(605, 29);
            tbCodigo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 35);
            label1.Name = "label1";
            label1.Size = new Size(84, 24);
            label1.TabIndex = 0;
            label1.Text = "Código*";
            // 
            // CadastroProdutoUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxCadastroProduto);
            Name = "CadastroProdutoUC";
            Size = new Size(676, 482);
            Load += CadastroProdutoUC_Load;
            groupBoxCadastroProduto.ResumeLayout(false);
            groupBoxCadastroProduto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCadastroProduto;
        private TextBox tbCodigo;
        private Label label1;
        private TextBox tbMarca;
        private Label label2;
        private TextBox tbDescricao;
        private Label label4;
        private TextBox tbModelo;
        private Label label3;
        private Button button2;
        private TextBox tbQuantidade;
        private CheckBox cbQuantidade;
        private Button btCancelar;
    }
}
