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
                    string query = "SELECT * FROM tb_procurados WHERE id_procurados = :id_procurados, nome_p = :nome_p";


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
            tela_procurados tela_Procurados = new tela_procurados();
            tela_Procurados.Show();
        }
    }
}
