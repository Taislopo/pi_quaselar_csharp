using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_QuaseLar
{
    public partial class Procurados : Form
    {
        public Procurados()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            detalhes_procurados detalhes_procurados = new detalhes_procurados();
            detalhes_procurados.Show();
        }

        private void Procurados_Load(object sender, EventArgs e)
        {

            private void CarregarCards()
        {
            // 🔹 Pega dados do banco
            var lista = new List<(int id, string nome, string caminho)>();

            using (SqlConnection con = new SqlConnection(conexaoString))
            {
                con.Open();
                string sql = "SELECT id, nome_arquivo, localizacao FROM tb_imagem";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string nome = dr.GetString(1);
                    string localizacao = dr.GetString(2);
                    string caminho = Path.Combine(localizacao, nome);
                    lista.Add((id, nome, caminho));
                }
            }

            // 🔹 Cria um FlowLayoutPanel pra organizar os cards automaticamente
            FlowLayoutPanel flow = new FlowLayoutPanel();
            flow.Dock = DockStyle.Fill;
            flow.AutoScroll = true;
            this.Controls.Add(flow);

            // 🔹 Cria um card para cada imagem
            foreach (var item in lista)
            {
                Panel card = new Panel();
                card.Size = new Size(180, 230);
                card.BorderStyle = BorderStyle.FixedSingle;
                card.Tag = item.id; // guarda o id do banco

                PictureBox pic = new PictureBox();
                pic.Size = new Size(160, 150);
                pic.Location = new Point(10, 10);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                if (File.Exists(item.caminho))
                    pic.Image = Image.FromFile(item.caminho);

                Label lbl = new Label();
                lbl.Text = item.nome;
                lbl.Location = new Point(10, 170);
                lbl.Size = new Size(160, 20);
                lbl.TextAlign = ContentAlignment.MiddleCenter;

                Button btnExcluir = new Button();
                btnExcluir.Text = "Excluir";
                btnExcluir.Size = new Size(80, 30);
                btnExcluir.Location = new Point(50, 195);
                btnExcluir.Click += BtnExcluir_Click; // evento de clique

                card.Controls.Add(pic);
                card.Controls.Add(lbl);
                card.Controls.Add(btnExcluir);
                flow.Controls.Add(card);
            }
        }
    }
    }
}
