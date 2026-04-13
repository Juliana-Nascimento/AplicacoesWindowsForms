namespace CadastrodeAlunos
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
            dvgAlunosCadastrados = new DataGridView();
            lbNome = new Label();
            lbEmail = new Label();
            btnCadastrar = new Button();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dvgAlunosCadastrados).BeginInit();
            SuspendLayout();
            // 
            // dvgAlunosCadastrados
            // 
            dvgAlunosCadastrados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgAlunosCadastrados.Location = new Point(12, 201);
            dvgAlunosCadastrados.Name = "dvgAlunosCadastrados";
            dvgAlunosCadastrados.Size = new Size(626, 237);
            dvgAlunosCadastrados.TabIndex = 0;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(24, 65);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 1;
            lbNome.Text = "Nome";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(24, 112);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(81, 152);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(70, 57);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(70, 104);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 450);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(btnCadastrar);
            Controls.Add(lbEmail);
            Controls.Add(lbNome);
            Controls.Add(dvgAlunosCadastrados);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dvgAlunosCadastrados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvgAlunosCadastrados;
        private Label lbNome;
        private Label lbEmail;
        private Button btnCadastrar;
        private TextBox txtNome;
        private TextBox txtEmail;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
