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
    public partial class FormDoacao : Form
    {
        public FormDoacao()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonImg_Click(object sender, EventArgs e)
        {
            string caminhoImagem = "";

            OpenFileDialog abrirArquivo = new OpenFileDialog();
            abrirArquivo.Filter = "Arquivos de imagem|*.jpg;*.jpeg;*.png;*.bmp";

            if (abrirArquivo.ShowDialog() == DialogResult.OK)
            {

                pictureBoxImg.Image = Image.FromFile(abrirArquivo.FileName);

                pictureBoxImg.SizeMode = PictureBoxSizeMode.Zoom;

                caminhoImagem = abrirArquivo.FileName;
            }
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

            if (nome == "" || raca == "" || idade_tipo == "" ||
       porte == "" || sexo == "" || castrado == "" || vacinado == "" ||
       motivo == "" || especie == "")
            {
                MessageBox.Show("Preencha todos os campos antes de enviar!");
                return;
            }

   
           

            if (porte != "Pequeno" && porte != "Médio" && porte != "Grande")
            {
                MessageBox.Show("Selecione um porte válido (Pequeno, Médio ou Grande).");
                return;
            }



















            string conn = "server=localhost;user=root;password=;database=db_quaselar";

            using (MySqlConnection conexao = new MySqlConnection(conn))
                try
                {
                    conexao.Open();
                    string query = "INSERT INTO tb_adocao (nome_pet, raca, sexo, porte, castrado, idade_valor, idade_tipo, motivo_da_adocao, especie, vacinado) VALUES (@nome_pet, @raca, @sexo, @porte, @castrado, @idade_valor, @idade_tipo, @motivo_da_adocao, @especie, @vacinado)";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@nome_pet", nome);
                    cmd.Parameters.AddWithValue("@raca", raca);
                    cmd.Parameters.AddWithValue("@sexo", sexo);
                    cmd.Parameters.AddWithValue("@porte", porte);
                    cmd.Parameters.AddWithValue("@castrado", castrado);
                    cmd.Parameters.AddWithValue("@idade_valor", idade);
                    cmd.Parameters.AddWithValue("@idade_tipo", idade_tipo);
                    cmd.Parameters.AddWithValue("@motivo_da_adocao", motivo);
                    cmd.Parameters.AddWithValue("@especie", especie);
                    cmd.Parameters.AddWithValue("@vacinado", vacinado); 
                    cmd.ExecuteNonQuery();
                     
                    MessageBox.Show("Doação cadastrada com sucesso!");


                    textBoxNome.Clear();
                    textBoxRaca.Clear();
                    textBoxIdade.Clear();
                    textBoxMotivo.Clear();
                    comboBoxIdade.SelectedIndex = -1;
                    comboBoxPorte.SelectedIndex = -1;
                    comboBoxSexo.SelectedIndex = -1;
                    comboBoxCastrado.SelectedIndex = -1;
                    comboBoxVacinado.SelectedIndex = -1;
                    comboBoxEspecie.SelectedIndex = -1;


                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao cadastrar doação: " + ex.Message);


                }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMotivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSexo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPorte_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIdade_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxVacinado_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCastrado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
