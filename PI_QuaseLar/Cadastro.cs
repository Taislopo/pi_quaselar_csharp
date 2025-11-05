using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PI_QuaseLar
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string email = textBoxEmail.Text;
            string senha = textBoxSenha.Text;
            string telefone = maskedTextBoxTelefone.Text;
            string endereco = textBoxEndereco.Text;
            string CEP = maskedTextBoxCep.Text;
            int CPF = int.Parse(maskedTextBoxCpf.Text);

            string conn = "server=localhost;user=root;password=;database=db_quaselar";

            using (MySqlConnection conexao = new MySqlConnection(conn))

                try
                {
                    conexao.Open();
                    string query = "INSERT INTO tb_usuario (nome, email, senha, telefone, CEP, CPF, endereco) VALUES (@nome, @email, @senha, @telefone, @CEP, @CPF, @endereco)";

                    MySqlCommand cmd = new MySqlCommand(query, conexao);

                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    cmd.Parameters.AddWithValue("@telefone", telefone);
                    cmd.Parameters.AddWithValue("@CEP", CEP);
                    cmd.Parameters.AddWithValue("@CPF", CPF);
                    cmd.Parameters.AddWithValue("@endereco", endereco);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Usuário cadastrado com sucesso!");



                    textBoxNome.Clear();
                    textBoxEmail.Clear();
                    textBoxSenha.Clear();
                    maskedTextBoxTelefone.Clear();
                    textBoxEndereco.Clear();
                    maskedTextBoxCep.Clear();
                    maskedTextBoxCpf.Clear();




                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                }
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox2SenhaLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
