namespace Controle_de_Estoque.View
{
    partial class AlterarProdutoUC
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
            tbDescricao = new TextBox();
            label4 = new Label();
            tbModelo = new TextBox();
            label3 = new Label();
            tbMarca = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            tbCodigo = new TextBox();
            label1 = new Label();
            btSalvar = new Button();
            Cancelar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tbDescricao
            // 
            tbDescricao.BorderStyle = BorderStyle.FixedSingle;
            tbDescricao.Enabled = false;
            tbDescricao.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbDescricao.Location = new Point(16, 204);
            tbDescricao.Multiline = true;
            tbDescricao.Name = "tbDescricao";
            tbDescricao.Size = new Size(605, 97);
            tbDescricao.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(16, 177);
            label4.Name = "label4";
            label4.Size = new Size(114, 24);
            label4.TabIndex = 12;
            label4.Text = "Descrição*";
            // 
            // tbModelo
            // 
            tbModelo.BorderStyle = BorderStyle.FixedSingle;
            tbModelo.Enabled = false;
            tbModelo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbModelo.Location = new Point(16, 134);
            tbModelo.Name = "tbModelo";
            tbModelo.Size = new Size(605, 29);
            tbModelo.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 107);
            label3.Name = "label3";
            label3.Size = new Size(86, 24);
            label3.TabIndex = 10;
            label3.Text = "Modelo*";
            // 
            // tbMarca
            // 
            tbMarca.BorderStyle = BorderStyle.FixedSingle;
            tbMarca.Enabled = false;
            tbMarca.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbMarca.Location = new Point(16, 56);
            tbMarca.Name = "tbMarca";
            tbMarca.Size = new Size(605, 29);
            tbMarca.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 29);
            label2.Name = "label2";
            label2.Size = new Size(77, 24);
            label2.TabIndex = 8;
            label2.Text = "Marca*";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbMarca);
            groupBox1.Controls.Add(tbDescricao);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbModelo);
            groupBox1.Location = new Point(17, 119);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(640, 323);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alterar informações";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(tbCodigo);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(17, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(640, 100);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar produto";
            // 
            // button2
            // 
            button2.Location = new Point(482, 51);
            button2.Name = "button2";
            button2.Size = new Size(120, 26);
            button2.TabIndex = 13;
            button2.Text = "Exibir todos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(345, 51);
            button1.Name = "button1";
            button1.Size = new Size(120, 26);
            button1.TabIndex = 12;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbCodigo
            // 
            tbCodigo.BorderStyle = BorderStyle.FixedSingle;
            tbCodigo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbCodigo.Location = new Point(18, 51);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(296, 29);
            tbCodigo.TabIndex = 11;
            tbCodigo.KeyPress += tbCodigo_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 24);
            label1.Name = "label1";
            label1.Size = new Size(76, 24);
            label1.TabIndex = 10;
            label1.Text = "Código";
            // 
            // btSalvar
            // 
            btSalvar.Enabled = false;
            btSalvar.Location = new Point(537, 448);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(120, 26);
            btSalvar.TabIndex = 16;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // Cancelar
            // 
            Cancelar.Enabled = false;
            Cancelar.Location = new Point(411, 448);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(120, 26);
            Cancelar.TabIndex = 17;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            Cancelar.Click += Cancelar_Click;
            // 
            // AlterarProdutoUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Cancelar);
            Controls.Add(btSalvar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AlterarProdutoUC";
            Size = new Size(688, 483);
            Load += AlterarProdutoUC_Load;
            KeyPress += AlterarProdutoUC_KeyPress;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbDescricao;
        private Label label4;
        private TextBox tbModelo;
        private Label label3;
        private TextBox tbMarca;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button2;
        private Button button1;
        private TextBox tbCodigo;
        private Label label1;
        private Button btSalvar;
        private Button Cancelar;
    }
}
