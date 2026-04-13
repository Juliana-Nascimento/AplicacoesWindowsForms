namespace Q3_PassagemPorDistancia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Variável
            double km, resultado;

            //Entrada
            km = Convert.ToDouble(txtDistancia.Text);


            //Processamento
            if (km <= 200)
            {
                resultado = km * 0.50;
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                resultado = km * 0.45;
                txtResultado.Text = resultado.ToString();
            }
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
