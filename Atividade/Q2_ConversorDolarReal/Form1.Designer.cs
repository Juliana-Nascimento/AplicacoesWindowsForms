namespace Q2_ConversorDolarReal
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
            label2 = new Label();
            lbResultado = new Label();
            txtCotacao = new TextBox();
            txtDolares = new TextBox();
            btnConverter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 0;
            label1.Text = "Cotação do dólar (R$):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 111);
            label2.Name = "label2";
            label2.Size = new Size(164, 15);
            label2.TabIndex = 1;
            label2.Text = "Quantidade em dólares (US$):";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(103, 161);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(96, 15);
            lbResultado.TabIndex = 2;
            lbResultado.Text = "Valor convertido:";
            // 
            // txtCotacao
            // 
            txtCotacao.Location = new Point(143, 57);
            txtCotacao.Name = "txtCotacao";
            txtCotacao.Size = new Size(100, 23);
            txtCotacao.TabIndex = 3;
            // 
            // txtDolares
            // 
            txtDolares.Location = new Point(182, 103);
            txtDolares.Name = "txtDolares";
            txtDolares.Size = new Size(100, 23);
            txtDolares.TabIndex = 4;
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(12, 153);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(75, 23);
            btnConverter.TabIndex = 5;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 388);
            Controls.Add(btnConverter);
            Controls.Add(txtDolares);
            Controls.Add(txtCotacao);
            Controls.Add(lbResultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbResultado;
        private TextBox txtCotacao;
        private TextBox txtDolares;
        private Button btnConverter;
    }
}
