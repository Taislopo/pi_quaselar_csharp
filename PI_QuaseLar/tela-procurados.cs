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
    public partial class tela_procurados : Form
    {
        public tela_procurados()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxConvivio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {

        }

        private void tela_procurados_Load(object sender, EventArgs e)
        {

        }

            private void buttonEnviar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string raca = textBoxRaca.Text;
            string especie = comboBoxEspecie.Text;
            int idade = int.Parse(textBoxIdade.Text);
            string idade_tipo = comboBoxIdade.Text;
            string porte = comboBoxPorte.Text;
            string sexo = comboBoxSexo.Text;
            string ultima = textBoxUltima.Text;

            string connStr = "server=localhost;user=root;password=;database=db_quaselar_oficial";


            using (MySqlConnection conexao = new MySqlConnection(connStr))
            {
                try
                {
                    conexao.Open();

                    string query = "INSERT INTO tb_procurados (nome_p, raca_p, idade_p, semanas_meses_anos_p, porte_p, especie_p, sexo_p, ultima_vez_visto) " +
                                   "VALUES (@nome_p, @raca_p, @idade_p, @semanas_meses_anos_p, @porte_p, @especie_p, @sexo_p, @ultima_vez_visto)";

                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@nome_p", nome);
                    cmd.Parameters.AddWithValue("@raca_p", raca);
                    cmd.Parameters.AddWithValue("@idade_p", idade);
                    cmd.Parameters.AddWithValue("@semanas_meses_anos_p", idade_tipo);
                    cmd.Parameters.AddWithValue("@porte_p", porte);
                    cmd.Parameters.AddWithValue("@especie_p", especie);
                    cmd.Parameters.AddWithValue("@sexo_p", sexo);
                    cmd.Parameters.AddWithValue("@ultima_vez_visto", ultima);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Procurado cadastrado com sucesso!");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao cadastrar Procurado: " + ex.Message);
                    return;
                }
            }

           
            //if (pictureBoxImg.Image == null)
            //{
            //    MessageBox.Show("Escolha uma imagem primeiro.");
            //    return;
            //}

            string pasta = Path.Combine(Application.StartupPath, "uploads");
            Directory.CreateDirectory(pasta);

            string nomeArquivo = $"img_{DateTime.Now.Ticks}.png";
            string caminho = Path.Combine(pasta, nomeArquivo);

            
            //pictureBoxImg.Image.Save(caminho, System.Drawing.Imaging.ImageFormat.Png);

            using (var conn = new MySqlConnection(connStr))
            using (var cmd = new MySqlCommand("INSERT INTO tb_img_procurados (nome_arquivo, localizacao) VALUES (@nome_arquivo, @localizacao)", conn))
            {
                cmd.Parameters.AddWithValue("@nome_arquivo", nomeArquivo);
                cmd.Parameters.AddWithValue("@localizacao", caminho);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Imagem salva na pasta e registrada no banco!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar imagem: " + ex.Message);
                }
            }

            textBoxNome.Clear();
            textBoxRaca.Clear();
            textBoxIdade.Clear();
            textBoxUltima.Clear();
            //pictureBoxImg.Image = null;
            comboBoxIdade.SelectedIndex = -1;
            comboBoxPorte.SelectedIndex = -1;
            comboBoxSexo.SelectedIndex = -1;
            comboBoxEspecie.SelectedIndex = -1;
        }



    


















        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIdade_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonImg_Click(object sender, EventArgs e)
        {

            //OpenFileDialog abrirArquivo = new OpenFileDialog();
            //abrirArquivo.Filter = "Arquivos de imagem|*.jpg;*.jpeg;*.png;*.bmp";

            //if (abrirArquivo.ShowDialog() == DialogResult.OK)
            //{

            //    pictureBoxImg.Image = Image.FromFile(abrirArquivo.FileName);

            //    pictureBoxImg.SizeMode = PictureBoxSizeMode.Zoom;
            //}
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxImg_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




