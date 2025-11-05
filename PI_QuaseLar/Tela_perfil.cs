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
    }
}
