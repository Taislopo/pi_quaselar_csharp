using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_QuaseLar
{
    public partial class detalhes_adocao : Form
    {
        string conexao = "server=localhost;user=root;password=;database=db_quaselar_oficial";
        int idAnimal;
        public detalhes_adocao()
        {
            InitializeComponent();
        }

        private void detalhes_adocao_Load(object sender, EventArgs e)
        {
            CarregarDetalhes();
        }


        private void CarregarDetalhes()
        {
         
            }





        }
}
