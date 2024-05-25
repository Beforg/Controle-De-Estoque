namespace Controle_de_Estoque.View
{
    partial class FormAjuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjuda));
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            gbTexto = new GroupBox();
            labelAjuda = new Label();
            groupBox2 = new GroupBox();
            label2 = new Label();
            gbTexto.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(175, 65);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(120, 19);
            radioButton6.TabIndex = 5;
            radioButton6.TabStop = true;
            radioButton6.Text = "Saída de Produtos";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(175, 31);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(132, 19);
            radioButton5.TabIndex = 4;
            radioButton5.TabStop = true;
            radioButton5.Text = "Entrada de Produtos";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(94, 65);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(72, 19);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Remover";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(94, 31);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(75, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Alteração";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(16, 65);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(56, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Busca";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(16, 31);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(72, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cadastro";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // gbTexto
            // 
            gbTexto.Controls.Add(labelAjuda);
            gbTexto.Location = new Point(12, 139);
            gbTexto.Name = "gbTexto";
            gbTexto.Size = new Size(371, 319);
            gbTexto.TabIndex = 1;
            gbTexto.TabStop = false;
            // 
            // labelAjuda
            // 
            labelAjuda.AutoSize = true;
            labelAjuda.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAjuda.Location = new Point(11, 19);
            labelAjuda.MaximumSize = new Size(350, 0);
            labelAjuda.Name = "labelAjuda";
            labelAjuda.Size = new Size(0, 18);
            labelAjuda.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(371, 100);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ajuda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 461);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 4;
            label2.Text = "v1.0.0";
            // 
            // FormAjuda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 480);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(gbTexto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormAjuda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ajuda";
            gbTexto.ResumeLayout(false);
            gbTexto.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox gbTexto;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private Label labelAjuda;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
    }
}