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
    public partial class ListaAnimaisProcurados : Form
    {
        public ListaAnimaisProcurados()
        {
            InitializeComponent();
        }

        private void dataGridViewAnimais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaAnimaisProcurados_Load(object sender, EventArgs e)
        {

            string conexaoBanco = "server=localhost;user=root;password=;database=db_quaselar_oficial";

            using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
            {
                try
                {
                    conexao.Open();
                    string query = "SELECT id_procurados, nome_p FROM tb_procurados";


                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);

                    dataGridViewAnimais.DataSource = tabela;

                    conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar cliente: erro na conexao com o banco" + ex.Message);
                }
            }
        }

        private void buttonProcurase_Click(object sender, EventArgs e)
        {
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            string conexaoBanco = "server=localhost;user=root;password=;database=db_quaselar_oficial";
            int id = Convert.ToInt32(dataGridViewAnimais.CurrentRow.Cells["id_procurados"].Value);

            using (MySqlConnection con = new MySqlConnection(conexaoBanco))
            {
                string query = "DELETE FROM tb_procurados WHERE id_procurados = @id";

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
                string query = "SELECT * FROM tb_procurados WHERE id_procurados = @id_procurados AND nome_p = @nome_p";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridViewAnimais.DataSource = dt;
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAnimais.CurrentRow == null)
            {
                MessageBox.Show("Selecione um animal primeiro!");
                return;
            }

            int id = Convert.ToInt32(dataGridViewAnimais.CurrentRow.Cells["id_procurados"].Value);
            EditarListaProcurados editarListaProcurados = new EditarListaProcurados(id);
            editarListaProcurados.ShowDialog();


            CarregarAnimais();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tela_procurados tela_Procurados = new tela_procurados();
            tela_Procurados.ShowDialog();
            CarregarAnimais();
        }

        public void CarregarAnimais()
        {
            string conexaoBanco = "server=localhost;user=root;password=;database=db_quaselar_oficial";

            using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
            {
                try
                {
                    conexao.Open();

                    string query = "SELECT id_procurados, nome_p FROM tb_procurados";
                    MySqlCommand comando = new MySqlCommand(query, conexao);

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);

                    dataGridViewAnimais.DataSource = tabela;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar animais: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewAnimais.CurrentRow == null)
            {
                MessageBox.Show("Selecione um animal primeiro!");
                return;
            }
            int id = Convert.ToInt32(dataGridViewAnimais.CurrentRow.Cells["id_procurados"].Value);
            detalhes_procurados detalhes_Procurados = new detalhes_procurados(id);
            detalhes_Procurados.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
