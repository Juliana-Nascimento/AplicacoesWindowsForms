using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace CadastrodeAlunos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            string Conexao = "server=localhost;user=root;password =;database=bdaluno_curso";
            MySqlConnection con = new MySqlConnection(Conexao);

            try
            {
                con.Open();

                string sql = "INSERT INTO tbalunos (nome_aluno, email)" + "Values (@nome, @email)";




                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro feito com sucesso");

                string sqll = "SELECT * FROM tbAlunos";
                MySqlDataAdapter da = new MySqlDataAdapter(sqll, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dvgAlunosCadastrados.DataSource = dt;

            }
            catch (Exception ex) { }
        }
    }
}
