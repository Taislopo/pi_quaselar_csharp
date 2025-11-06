using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            if (nome == "" || raca == "" || idade == 0 || idade_tipo == "" || porte == "" || sexo == "" || castrado == "" || vacinado == "" || motivo == "" || especie == "")
            {
                MessageBox.Show("Preencha todos os campos antes de enviar!");
                return;
            }


            string conn = "server=localhost;user=root;password=;database=db_quaselar_oficial";

            using (MySqlConnection conexao = new MySqlConnection(conn))
                try
                {
                    conexao.Open();
                    string query = "INSERT INTO tb_adocao (nome_pet, raca, sexo, porte, castrado, idade, semanas_meses_anos, motivo_da_doacao, especie, vacinado) VALUES (@nome_pet, @raca, @sexo, @porte, @castrado, @idade, @semanas_meses_anos, @motivo_da_doacao, @especie, @vacinado)";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
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

                    MessageBox.Show("Doação cadastrada com sucesso!");



                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao cadastrar doação: " + ex.Message);


                }



            if (pictureBoxImg.Image == null)
            {
                MessageBox.Show("Escolha uma imagem primeiro.");
                return;
            }

            string pasta = Path.Combine(Application.StartupPath, "uploads");
            Directory.CreateDirectory(pasta);

            string nomeArquivo = $"img_{DateTime.Now.Ticks}.png";
            string caminho = Path.Combine(pasta, nomeArquivo);


            pictureBoxImg.Image.Save(caminho, System.Drawing.Imaging.ImageFormat.Png);

            using (var conexaoImg = new MySqlConnection(conn))
            using (var cmd = new MySqlCommand("INSERT INTO tb_img_animal (nome_arquivo, localizacao) VALUES (@nome_arquivo, @localizacao)", conexaoImg))
            {
                cmd.Parameters.AddWithValue("@nome_arquivo", nomeArquivo);
                cmd.Parameters.AddWithValue("@localizacao", caminho);

                try
                {
                    conexaoImg.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Imagem salva na pasta e registrada no banco!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar imagem: " + ex.Message);
                }



                textBoxNome.Clear();
                textBoxRaca.Clear();
                textBoxIdade.Clear();
                textBoxMotivo.Clear();
                pictureBoxImg.Image = null;
                comboBoxIdade.SelectedIndex = -1;
                comboBoxPorte.SelectedIndex = -1;
                comboBoxSexo.SelectedIndex = -1;
                comboBoxCastrado.SelectedIndex = -1;
                comboBoxVacinado.SelectedIndex = -1;
                comboBoxEspecie.SelectedIndex = -1;








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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
