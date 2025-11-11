using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_QuaseLar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usuario = textBoxUsuario.Text;
            string senha = textBoxSenhaLogin.Text;

            if (usuario == "" || senha == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            string conn = "server=localhost;user=root;password=;database=db_quaselar_oficial";
            using (MySqlConnection conexao = new MySqlConnection(conn))
            {
                try
                {
                    conexao.Open();

                 
                    string sql = "SELECT * FROM tb_usuario WHERE email = @email AND senha = @senha";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@email", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    MySqlDataReader leitor = cmd.ExecuteReader();

                    if (leitor.Read())
                    {
                        MessageBox.Show("Login realizado com sucesso!");
                         Tela_Inicial telaInicial = new Tela_Inicial();
                        telaInicial.Show();
                        this.Hide(); 
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos!");
                    }

                    conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }


        

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro(); 
            cadastro.Show();
        }

        private void textBoxSenhaLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
