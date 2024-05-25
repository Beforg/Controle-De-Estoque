namespace Controle_de_Estoque
{
    partial class FormControleDeEstoque
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormControleDeEstoque));
            menuStrip1 = new MenuStrip();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            cadastrarProdutoToolStripMenuItem = new ToolStripMenuItem();
            buscarProdutoToolStripMenuItem = new ToolStripMenuItem();
            todosToolStripMenuItem = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            alterarProdutoToolStripMenuItem = new ToolStripMenuItem();
            removerProdutoToolStripMenuItem = new ToolStripSeparator();
            removerProdutoToolStripMenuItem1 = new ToolStripMenuItem();
            gerenciamentoToolStripMenuItem = new ToolStripMenuItem();
            entradaToolStripMenuItem = new ToolStripMenuItem();
            saídaToolStripMenuItem = new ToolStripMenuItem();
            tabControlEstoque = new TabControl();
            listaDeImagens = new ImageList(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sistemaToolStripMenuItem, estoqueToolStripMenuItem, gerenciamentoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(690, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajudaToolStripMenuItem, sobreToolStripMenuItem, sairToolStripMenuItem });
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(60, 20);
            sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.Image = Properties.Resources.ajuda;
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(180, 22);
            ajudaToolStripMenuItem.Text = "Ajuda";
            ajudaToolStripMenuItem.Click += ajudaToolStripMenuItem_Click;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Image = Properties.Resources.sobre;
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(180, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Image = Properties.Resources.sair;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarProdutoToolStripMenuItem, buscarProdutoToolStripMenuItem, alterarProdutoToolStripMenuItem, removerProdutoToolStripMenuItem, removerProdutoToolStripMenuItem1 });
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(61, 20);
            estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // cadastrarProdutoToolStripMenuItem
            // 
            cadastrarProdutoToolStripMenuItem.Image = Properties.Resources.cadastrar;
            cadastrarProdutoToolStripMenuItem.Name = "cadastrarProdutoToolStripMenuItem";
            cadastrarProdutoToolStripMenuItem.Size = new Size(170, 22);
            cadastrarProdutoToolStripMenuItem.Text = "Cadastrar Produto";
            cadastrarProdutoToolStripMenuItem.Click += cadastrarProdutoToolStripMenuItem_Click;
            // 
            // buscarProdutoToolStripMenuItem
            // 
            buscarProdutoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { todosToolStripMenuItem, buscarToolStripMenuItem });
            buscarProdutoToolStripMenuItem.Image = Properties.Resources.pesquisa;
            buscarProdutoToolStripMenuItem.Name = "buscarProdutoToolStripMenuItem";
            buscarProdutoToolStripMenuItem.Size = new Size(170, 22);
            buscarProdutoToolStripMenuItem.Text = "Buscar Produto";
            // 
            // todosToolStripMenuItem
            // 
            todosToolStripMenuItem.Image = Properties.Resources.todos;
            todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            todosToolStripMenuItem.Size = new Size(113, 22);
            todosToolStripMenuItem.Text = "Todos";
            todosToolStripMenuItem.Click += todosToolStripMenuItem_Click;
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.Image = Properties.Resources.barcode;
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(113, 22);
            buscarToolStripMenuItem.Text = "Código";
            buscarToolStripMenuItem.Click += buscarToolStripMenuItem_Click;
            // 
            // alterarProdutoToolStripMenuItem
            // 
            alterarProdutoToolStripMenuItem.Image = Properties.Resources.edit;
            alterarProdutoToolStripMenuItem.Name = "alterarProdutoToolStripMenuItem";
            alterarProdutoToolStripMenuItem.Size = new Size(170, 22);
            alterarProdutoToolStripMenuItem.Text = "Alterar Produto";
            alterarProdutoToolStripMenuItem.Click += alterarProdutoToolStripMenuItem_Click;
            // 
            // removerProdutoToolStripMenuItem
            // 
            removerProdutoToolStripMenuItem.Name = "removerProdutoToolStripMenuItem";
            removerProdutoToolStripMenuItem.Size = new Size(167, 6);
            // 
            // removerProdutoToolStripMenuItem1
            // 
            removerProdutoToolStripMenuItem1.Image = Properties.Resources.delete;
            removerProdutoToolStripMenuItem1.Name = "removerProdutoToolStripMenuItem1";
            removerProdutoToolStripMenuItem1.Size = new Size(170, 22);
            removerProdutoToolStripMenuItem1.Text = "Remover Produto";
            removerProdutoToolStripMenuItem1.Click += removerProdutoToolStripMenuItem1_Click;
            // 
            // gerenciamentoToolStripMenuItem
            // 
            gerenciamentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { entradaToolStripMenuItem, saídaToolStripMenuItem });
            gerenciamentoToolStripMenuItem.Name = "gerenciamentoToolStripMenuItem";
            gerenciamentoToolStripMenuItem.Size = new Size(65, 20);
            gerenciamentoToolStripMenuItem.Text = "Controle";
            // 
            // entradaToolStripMenuItem
            // 
            entradaToolStripMenuItem.Image = Properties.Resources.input;
            entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            entradaToolStripMenuItem.Size = new Size(180, 22);
            entradaToolStripMenuItem.Text = "Entrada";
            entradaToolStripMenuItem.Click += entradaToolStripMenuItem_Click;
            // 
            // saídaToolStripMenuItem
            // 
            saídaToolStripMenuItem.Image = Properties.Resources.output;
            saídaToolStripMenuItem.Name = "saídaToolStripMenuItem";
            saídaToolStripMenuItem.Size = new Size(180, 22);
            saídaToolStripMenuItem.Text = "Saída";
            saídaToolStripMenuItem.Click += saídaToolStripMenuItem_Click;
            // 
            // tabControlEstoque
            // 
            tabControlEstoque.Dock = DockStyle.Fill;
            tabControlEstoque.ImageList = listaDeImagens;
            tabControlEstoque.Location = new Point(0, 24);
            tabControlEstoque.Name = "tabControlEstoque";
            tabControlEstoque.SelectedIndex = 0;
            tabControlEstoque.Size = new Size(690, 504);
            tabControlEstoque.TabIndex = 1;
            tabControlEstoque.SelectedIndexChanged += tabControlEstoque_SelectedIndexChanged;
            tabControlEstoque.MouseDown += tabControlEstoque_MouseDown;
            // 
            // listaDeImagens
            // 
            listaDeImagens.ColorDepth = ColorDepth.Depth8Bit;
            listaDeImagens.ImageStream = (ImageListStreamer)resources.GetObject("listaDeImagens.ImageStream");
            listaDeImagens.TransparentColor = Color.Transparent;
            listaDeImagens.Images.SetKeyName(0, "barcode.png");
            listaDeImagens.Images.SetKeyName(1, "output.png");
            listaDeImagens.Images.SetKeyName(2, "input.png");
            listaDeImagens.Images.SetKeyName(3, "busca-codigo.png");
            listaDeImagens.Images.SetKeyName(4, "edit.png");
            listaDeImagens.Images.SetKeyName(5, "pesquisa.png");
            listaDeImagens.Images.SetKeyName(6, "cadastrar.png");
            // 
            // FormControleDeEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 528);
            Controls.Add(tabControlEstoque);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FormControleDeEstoque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Estoque ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem cadastrarProdutoToolStripMenuItem;
        private ToolStripMenuItem buscarProdutoToolStripMenuItem;
        private ToolStripMenuItem alterarProdutoToolStripMenuItem;
        private ToolStripMenuItem gerenciamentoToolStripMenuItem;
        private ToolStripMenuItem entradaToolStripMenuItem;
        private ToolStripMenuItem saídaToolStripMenuItem;
        private TabControl tabControlEstoque;
        private ToolStripMenuItem todosToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ImageList listaDeImagens;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripSeparator removerProdutoToolStripMenuItem;
        private ToolStripMenuItem removerProdutoToolStripMenuItem1;
    }
}
