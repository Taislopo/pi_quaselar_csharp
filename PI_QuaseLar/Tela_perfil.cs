using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PI_QuaseLar
{
    public partial class Tela_perfil : Form
    {
        public Tela_perfil()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tela_procurados tela_Procurados = new tela_procurados();
            tela_Procurados.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDoacao form = new FormDoacao();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Tela_perfil_Load(object sender, EventArgs e)
        {
            CarregarAdocao();
            CarregarProcurado();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public class Conexao
        {
            public static MySqlConnection Conectar()
            {
                string conn = "server=localhost;user=root;password=;database=db_quaselar_oficial";
                return new MySqlConnection(conn);
            }
        }


        private void CarregarProcurado()
        {
            using (var conexao = Conexao.Conectar())
            {
                conexao.Open();

                string query = @"
                    SELECT p.nome_p, i.localizacao 
                    FROM tb_procurados p
                    INNER JOIN tb_img_procurados i ON p.id_procurados = i.id_procurados
                    LIMIT 1;";

                MySqlCommand cmd = new MySqlCommand(query, conexao);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    labelNomeProcurado.Text = dr["nome_p"].ToString();

                    string nomeArquivo = dr["localizacao"].ToString();
                    string caminhoImagem = Path.Combine(Application.StartupPath, nomeArquivo);

                    if (File.Exists(caminhoImagem))
                    {
                        pictureBoxImgProcurados.Image = Image.FromFile(caminhoImagem);
                        pictureBoxImgProcurados.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        MessageBox.Show("Imagem não encontrada: " + caminhoImagem);
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado.");
                }

                dr.Close();
             }
        }


        private void CarregarAdocao()
        {
            using (var conexao = Conexao.Conectar())
            {
                conexao.Open();

                string query = @"
                    SELECT p.nome_pet, i.localizacao 
                    FROM tb_adocao p
                    INNER JOIN tb_img_animal i ON p.id_adocao = i.id_adocao
                    LIMIT 1;";

                MySqlCommand cmd = new MySqlCommand(query, conexao);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    labelNomeAdocao.Text = dr["nome_pet"].ToString();

                    string caminhoImagem = dr["localizacao"].ToString();
                    if (File.Exists(caminhoImagem))
                    {
                        pictureBoxImgAdocao.Image = Image.FromFile(caminhoImagem);
                        pictureBoxImgAdocao.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        MessageBox.Show("Imagem não encontrada: " + caminhoImagem);
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado.");
                }

                dr.Close();
            }

        }



        }
    }
