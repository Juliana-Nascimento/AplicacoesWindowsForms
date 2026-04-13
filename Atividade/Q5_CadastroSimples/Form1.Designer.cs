namespace Q5_CadastroSimples
{
    partial class Form1
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
            label1 = new Label();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            label2 = new Label();
            btnAdicionar = new Button();
            lstPessoas = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 42);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome: ";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(71, 34);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 1;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(71, 70);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(100, 23);
            txtIdade.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 78);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Idade: ";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(61, 120);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // lstPessoas
            // 
            lstPessoas.FormattingEnabled = true;
            lstPessoas.ItemHeight = 15;
            lstPessoas.Location = new Point(191, 34);
            lstPessoas.Name = "lstPessoas";
            lstPessoas.Size = new Size(166, 319);
            lstPessoas.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 395);
            Controls.Add(lstPessoas);
            Controls.Add(btnAdicionar);
            Controls.Add(label2);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private TextBox txtIdade;
        private Label label2;
        private Button btnAdicionar;
        private ListBox lstPessoas;
    }
}
