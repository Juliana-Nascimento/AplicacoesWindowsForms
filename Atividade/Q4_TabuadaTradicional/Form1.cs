namespace Q4_TabuadaTradicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            //Váriavel
            int u, resultado;

            //Entrada
            u = Convert.ToInt32(txtNumero.Text);
            
            //Processamento
            for (int i = 0; i <= 10; i++)
            {
               resultado = u * i;

                //Saida
                lstTabuada.Items.Add(u + " x " + i + " =  " + resultado);
            }                   
        }
    }
}
