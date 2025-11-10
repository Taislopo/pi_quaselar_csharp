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
using MySql.Data.MySqlClient;

namespace PI_QuaseLar
{
    public partial class detalhes_procurados : Form
    {
        int petId;

        public detalhes_procurados(int Id)
        {
            InitializeComponent();
            petId = Id;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void detalhes_procurados_Load(object sender, EventArgs e)
        {
            CarregarDetalhes();
        }

        private void buttonCasinha_Click(object sender, EventArgs e)
        {
            Tela_Inicial Tela_Inicial = new Tela_Inicial();
            Tela_Inicial.Show();
        }





        private void CarregarDetalhes()
        {
            string conn = "server=localhost;user=root;password=;database=db_quaselar_oficial";

            try
            {
                // === 1️⃣ Buscar as informações do pet ===
                using (MySqlConnection conexao = new MySqlConnection(conn))
                {
                    string query = "SELECT * FROM tb_procurados WHERE id_procurados = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@id", petId);

                    conexao.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            labelNome.Text = reader["nome_p"].ToString();
                            labelIdade.Text = reader["idade_p"].ToString() + " " + reader["semanas_meses_anos_p"].ToString();
                            labelSexo.Text = reader["sexo_p"].ToString();
                            labelEspecie.Text = reader["especie_p"].ToString();
                            labelPorte.Text = reader["porte_p"].ToString();
                            labelRaca.Text = reader["raca_p"].ToString();
                            labelUltima.Text = reader["ultima_vez_visto"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("⚠️ Nenhum registro encontrado para o ID " + petId);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("💥 Erro: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //    // === 2️⃣ Buscar a imagem separadamente ===
        //    using (MySqlConnection conexaoImg = new MySqlConnection(conn))
        //    {
        //        string queryImg = "SELECT localizacao FROM tb_img_procurados WHERE id_procurados = @id LIMIT 1";
        //        MySqlCommand cmdImg = new MySqlCommand(queryImg, conexaoImg);
        //        cmdImg.Parameters.AddWithValue("@id", petId);

        //        conexaoImg.Open();

        //        object caminhoImg = cmdImg.ExecuteScalar();

        //        MessageBox.Show("📂 Valor retornado do banco:\n" + (caminhoImg != null ? caminhoImg.ToString() : "NULO"));

        //        if (caminhoImg != null)
        //        {
        //            string caminho = caminhoImg.ToString().Trim();

        //            // Se for relativo, converter para caminho completo
        //            if (caminho.StartsWith("./") || caminho.StartsWith("/uploads"))
        //            {
        //                string pastaUploads = Path.Combine(Application.StartupPath, "uploads");
        //                string nomeArquivo = Path.GetFileName(caminho);
        //                caminho = Path.Combine(pastaUploads, nomeArquivo);
        //            }

        //            MessageBox.Show("🧩 Tentando carregar imagem de:\n" + caminho);

        //            if (File.Exists(caminho))
        //            {
        //                pictureBoxImg.Image = Image.FromFile(caminho);
        //                pictureBoxImg.SizeMode = PictureBoxSizeMode.Zoom;
        //            }
        //            else
        //            {
        //                MessageBox.Show("❌ Imagem não encontrada no caminho:\n" + caminho);
        //                pictureBoxImg.Image = null;
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("🚫 Nenhum caminho de imagem retornado do banco.");
        //            pictureBoxImg.Image = null;
        //        }
        //    }
        //}










    }
}
