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
    public partial class EditarListaProcurados : Form
    {
        int petId;
        public EditarListaProcurados(int id)
        {
            InitializeComponent();
            petId = id;
        }

        private void EditarListaProcurados_Load(object sender, EventArgs e)
        {
            string conn = "server=localhost;user=root;password=;database=db_quaselar_oficial";

            using (MySqlConnection conexao = new MySqlConnection(conn))
            {
                string query = "SELECT * FROM tb_procurados WHERE id_procurados = @id";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@id", petId);
                conexao.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Preenche os campos com os valores atuais
                    textBoxNome.Text = reader["nome_p"].ToString();
                    textBoxRaca.Text = reader["raca_p"].ToString();
                    textBoxIdade.Text = reader["idade_p"].ToString();
                    comboBoxIdade.Text = reader["semanas_meses_anos_p"].ToString();
                    comboBoxPorte.Text = reader["porte_p"].ToString();
                    comboBoxSexo.Text = reader["sexo_p"].ToString();
                    textBoxUltima.Text = reader["ultima_vez_visto"].ToString();
                    comboBoxEspecie.Text = reader["especie_p"].ToString();
                }
            }
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string raca = textBoxRaca.Text;
            int idade = int.Parse(textBoxIdade.Text);
            string idade_tipo = comboBoxIdade.Text;
            string porte = comboBoxPorte.Text;
            string sexo = comboBoxSexo.Text;
            string ultima = textBoxUltima.Text;
            string especie = comboBoxEspecie.Text;

            if (nome == "" || raca == "" || idade_tipo == "" || porte == "" || sexo == "" || ultima == "" || especie == "")
            {
                MessageBox.Show("Preencha todos os campos antes de atualizar!");
                return;
            }

            string conn = "server=localhost;user=root;password=;database=db_quaselar_oficial";

            using (MySqlConnection conexao = new MySqlConnection(conn))
            {
                try
                {
                    conexao.Open();
                    string query = @"UPDATE tb_procurados 
                                     SET nome_p = @nome_p,
                                         raca_p = @raca_p,
                                         sexo_p = @sexo_p,
                                         porte_p = @porte_P,
                                         idade_p = @idade_p,
                                         semanas_meses_anos_p = @semanas_meses_anos_p,
                                         ultima_vez_visto = @ultima_vez_visto,
                                         especie_P = @especie_p,
                                     WHERE id_procurados = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@id", petId);
                    cmd.Parameters.AddWithValue("@nome_p", nome);
                    cmd.Parameters.AddWithValue("@raca_p", raca);
                    cmd.Parameters.AddWithValue("@sexo_p", sexo);
                    cmd.Parameters.AddWithValue("@porte_p", porte);
                    cmd.Parameters.AddWithValue("@idade_p", idade);
                    cmd.Parameters.AddWithValue("@semanas_meses_anos_p", idade_tipo);
                    cmd.Parameters.AddWithValue("@ultima_vez_visto", ultima);
                    cmd.Parameters.AddWithValue("@especie", especie);
                 

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro atualizado com sucesso!");

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar: " + ex.Message);
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

