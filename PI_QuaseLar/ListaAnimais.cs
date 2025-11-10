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
    public partial class ListaAnimais : Form
    {
        public ListaAnimais()
        {
            InitializeComponent();
        }

        private void buttonProcurase_Click(object sender, EventArgs e)
        {
            tela_procurados tela_Procurados = new tela_procurados();
            tela_Procurados.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

          FormDoacao formDoacao = new FormDoacao();
            formDoacao.ShowDialog();

            CarregarAnimais();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void ListaAnimais_Load(object sender, EventArgs e)
        {

            CarregarAnimais();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {

            string conexaoBanco = "server=localhost;user=root;password=;database=db_quaselar_oficial";
            int id = Convert.ToInt32(dataGridViewAnimais.CurrentRow.Cells["id_adocao"].Value);

            using (MySqlConnection con = new MySqlConnection(conexaoBanco))
            {
                string query = "DELETE FROM tb_adocao WHERE id_adocao = @id";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Animal excluído com sucesso!");
            }

            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            string conexaoBanco = "server=localhost;user=root;password=;database=db_quaselar_oficial";
            using (MySqlConnection con = new MySqlConnection(conexaoBanco))
            {
                string query = "SELECT id_adocao, nome_pet FROM tb_adocao";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridViewAnimais.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewAnimais.CurrentRow == null)
            {
                MessageBox.Show("Selecione um animal primeiro!");
                return;
            }
            int id = Convert.ToInt32(dataGridViewAnimais.CurrentRow.Cells["id_adocao"].Value);
            detalhes_adocao detalhes_Adocao = new detalhes_adocao(id);
            detalhes_Adocao.ShowDialog();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAnimais.CurrentRow == null)
            {
                MessageBox.Show("Selecione um animal primeiro!");
                return;
            }

            int id = Convert.ToInt32(dataGridViewAnimais.CurrentRow.Cells["id_adocao"].Value);

            EditarAnimaisDoacao editarForm = new EditarAnimaisDoacao(id);
            editarForm.ShowDialog();

           
            CarregarAnimais();

        }

        public void CarregarAnimais()
        {
            string conexaoBanco = "server=localhost;user=root;password=;database=db_quaselar_oficial";

            using (MySqlConnection con = new MySqlConnection(conexaoBanco))
            {
                string query = "SELECT id_adocao, nome_pet FROM tb_adocao";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                dataGridViewAnimais.DataSource = dt;


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    
