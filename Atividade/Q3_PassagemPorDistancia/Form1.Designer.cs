namespace Q3_PassagemPorDistancia
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
            txtDistancia = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 70);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "Distância (km):";
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(139, 62);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(100, 23);
            txtDistancia.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(208, 130);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(261, 70);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(43, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Preço: ";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(310, 62);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 245);
            Controls.Add(txtResultado);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtDistancia);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDistancia;
        private Button btnCalcular;
        private Label lblResultado;
        private TextBox txtResultado;
    }
}
