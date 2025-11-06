using MySql.Data.MySqlClient;
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
        private void Procurados_Load(object sender, EventArgs e)
        {
          
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

        private void buttonCasinha_Click(object sender, EventArgs e)
        {
            Tela_Inicial tela_Inicial = new Tela_Inicial();
            tela_Inicial.Show();

        }
       
        
    }
}
