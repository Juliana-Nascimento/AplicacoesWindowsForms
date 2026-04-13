namespace Q1_ConversorCF
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
            txtCelcius = new TextBox();
            btnConverter = new Button();
            lbResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 42);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Celcius (C°):";
            // 
            // txtCelcius
            // 
            txtCelcius.Location = new Point(95, 34);
            txtCelcius.Name = "txtCelcius";
            txtCelcius.Size = new Size(100, 23);
            txtCelcius.TabIndex = 1;
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(17, 79);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(75, 23);
            btnConverter.TabIndex = 2;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(107, 83);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(88, 15);
            lbResultado.TabIndex = 3;
            lbResultado.Text = "Fahrenheit (F°):";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 192);
            Controls.Add(lbResultado);
            Controls.Add(btnConverter);
            Controls.Add(txtCelcius);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCelcius;
        private Button btnConverter;
        private Label lbResultado;
    }
}
