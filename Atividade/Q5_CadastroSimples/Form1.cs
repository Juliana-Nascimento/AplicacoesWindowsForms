namespace Q5_CadastroSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtIdade.Text))
            {
                MessageBox.Show("Por favor, preencha os campos");
                return;
            }
            else

            {
                Pessoa novoCadastro = new Pessoa();

                novoCadastro.Nome = txtNome.Text;
                novoCadastro.Idade = txtIdade.Text;

                Repositorio.Cadastrado.Add(novoCadastro);

                lstPessoas.Items.Add($"{novoCadastro.Nome} {novoCadastro.Idade}");
            }

        }
    }
}
