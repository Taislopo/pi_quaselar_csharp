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
    public partial class Tela_Inicial : Form
    {
        public Tela_Inicial()
        {
            InitializeComponent();
        }

        private void Tela_Inicial_Load(object sender, EventArgs e)
        {

        }

        private void buttonPerfil_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void buttonPerfil_Click_1(object sender, EventArgs e)
        {
            Tela_perfil tela_Perfil = new Tela_perfil();
            tela_Perfil.Show();
        }

        private void buttonProcurase_Click(object sender, EventArgs e)
        {
            Procurados procurados = new Procurados();
            procurados.Show();
        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaAdocao telaAdocao = new TelaAdocao();
            telaAdocao.Show();
        }
    }
}
