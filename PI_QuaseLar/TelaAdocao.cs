using MySql.Data.MySqlClient;
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
namespace PI_QuaseLar
{
    public partial class TelaAdocao : Form
    {
            string conn = "server=localhost;user=root;password=;database=db_quaselar_oficial";
        public TelaAdocao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TelaAdocao_Load(object sender, EventArgs e)
        {
            CarregarAnimais();
        }




        private void CarregarAnimais()
        {
            string sql = @"
        SELECT 
        a.id_adocao AS id_animal,
        a.nome_pet,
        i.localizacao AS localizacao_imagem
        FROM tb_adocao a
        INNER JOIN tb_img_animal i ON a.id_adocao = i.id_adocao";

            using (MySqlConnection conexao = new MySqlConnection(conn))
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int idAnimal = Convert.ToInt32(dr["id_animal"]);
                    string nome = dr["nome_pet"].ToString();
                    string caminhoImg = dr["localizacao_imagem"].ToString();

                    labelNome.Text = nome;

                    if (File.Exists(caminhoImg))
                        pictureBoxImg.Image = Image.FromFile(caminhoImg);
                    else
                    pictureBoxImg.Image = null;

                    buttonMais.Tag = idAnimal;

                }












            }
        }
    }
}

