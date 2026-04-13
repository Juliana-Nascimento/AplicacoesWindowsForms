namespace Q1_ConversorCF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double C, F;

            //Entrada
            C = Convert.ToDouble(txtCelcius.Text);

            //Processamento
            F = (C * 9 / 5) + 32;

            //Saída
            lbResultado.Text = "Fahrenheit (F°): " + F.ToString();
        }
    }
}
