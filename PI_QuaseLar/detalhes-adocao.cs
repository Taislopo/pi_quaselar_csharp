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
    public partial class detalhes_adocao : Form
    {
        int petId;


        public detalhes_adocao(int id)
        {
            InitializeComponent();
            petId = id;
        }

        private void detalhes_adocao_Load(object sender, EventArgs e)
        {
            
            CarregarDetalhes();
        }


        private void CarregarDetalhes()
        {
            string conn = "server=localhost;user=root;password=;database=db_quaselar_oficial";

            try
            {
                // === 1️⃣ Buscar as informações do pet ===
                using (MySqlConnection conexao = new MySqlConnection(conn))
                {
                    string query = "SELECT * FROM tb_adocao WHERE id_adocao = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@id", petId);

                    conexao.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            labelNome.Text = reader["nome_pet"].ToString();
                            labelIdade.Text = reader["idade"].ToString() + " " + reader["semanas_meses_anos"].ToString();
                            labelSexo.Text = reader["sexo"].ToString();
                            labelEspecie.Text = reader["especie"].ToString();
                            labelVacinado.Text = reader["vacinado"].ToString();
                            labelPorte.Text = reader["porte"].ToString();
                            labelRaca.Text = reader["raca"].ToString();
                            labelCastrado.Text = reader["castrado"].ToString();
                            labelMotivo.Text = reader["motivo_da_doacao"].ToString();
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


        //    // === 2️⃣ Buscar a imagem separadamente ===
        //    using (MySqlConnection conexaoImg = new MySqlConnection(conn))
        //    {
        //        string queryImg = "SELECT localizacao FROM tb_img_animal WHERE id_adocao = @id LIMIT 1";
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




        private void buttonCasinha_Click(object sender, EventArgs e)
        {
            Tela_Inicial tela_Inicial = new Tela_Inicial();
            tela_Inicial.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelSexo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
