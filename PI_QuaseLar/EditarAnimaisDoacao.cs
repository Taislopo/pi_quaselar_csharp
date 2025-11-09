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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PI_QuaseLar
{
    public partial class EditarAnimaisDoacao : Form
    {
        int petId;
        public EditarAnimaisDoacao(int id)
        {
          

            InitializeComponent();
            petId = id; 
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
          
            string nome = textBoxNome.Text;
            string raca = textBoxRaca.Text;
            int idade = int.Parse(textBoxIdade.Text);
            string idade_tipo = comboBoxIdade.Text;
            string porte = comboBoxPorte.Text;
            string sexo = comboBoxSexo.Text;
            string castrado = comboBoxCastrado.Text;
            string vacinado = comboBoxVacinado.Text;
            string motivo = textBoxMotivo.Text;
            string especie = comboBoxEspecie.Text;

            if (nome == "" || raca == "" || idade_tipo == "" || porte == "" || sexo == "" || castrado == "" || vacinado == "" || motivo == "" || especie == "")
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
                    string query = @"UPDATE tb_adocao 
                                     SET nome_pet = @nome_pet,
                                         raca = @raca,
                                         sexo = @sexo,
                                         porte = @porte,
                                         castrado = @castrado,
                                         idade = @idade,
                                         semanas_meses_anos = @semanas_meses_anos,
                                         motivo_da_doacao = @motivo_da_doacao,
                                         especie = @especie,
                                         vacinado = @vacinado
                                     WHERE id_adocao = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@id", petId);
                    cmd.Parameters.AddWithValue("@nome_pet", nome);
                    cmd.Parameters.AddWithValue("@raca", raca);
                    cmd.Parameters.AddWithValue("@sexo", sexo);
                    cmd.Parameters.AddWithValue("@porte", porte);
                    cmd.Parameters.AddWithValue("@castrado", castrado);
                    cmd.Parameters.AddWithValue("@idade", idade);
                    cmd.Parameters.AddWithValue("@semanas_meses_anos", idade_tipo);
                    cmd.Parameters.AddWithValue("@motivo_da_doacao", motivo);
                    cmd.Parameters.AddWithValue("@especie", especie);
                    cmd.Parameters.AddWithValue("@vacinado", vacinado);

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

        private void EditarAnimaisDoacao_Load(object sender, EventArgs e)
        {

            string conn = "server=localhost;user=root;password=;database=db_quaselar_oficial";

            using (MySqlConnection conexao = new MySqlConnection(conn))
            {
                string query = "SELECT * FROM tb_adocao WHERE id_adocao = @id";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@id", petId);
                conexao.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Preenche os campos com os valores atuais
                    textBoxNome.Text = reader["nome_pet"].ToString();
                    textBoxRaca.Text = reader["raca"].ToString();
                    textBoxIdade.Text = reader["idade"].ToString();
                    comboBoxIdade.Text = reader["semanas_meses_anos"].ToString();
                    comboBoxPorte.Text = reader["porte"].ToString();
                    comboBoxSexo.Text = reader["sexo"].ToString();
                    comboBoxCastrado.Text = reader["castrado"].ToString();
                    comboBoxVacinado.Text = reader["vacinado"].ToString();
                    textBoxMotivo.Text = reader["motivo_da_doacao"].ToString();
                    comboBoxEspecie.Text = reader["especie"].ToString();
                }

            }
        
        }

    }
}


