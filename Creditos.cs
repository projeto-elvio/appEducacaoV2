using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appEducacao
{
    public partial class Creditos : Form
    {
        public Creditos()
        {
            InitializeComponent();
        }

        /*private void label7_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }
        */

        private void lbl_home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void lbl_familia_Click(object sender, EventArgs e)
        {
            Familia familia = new Familia();
            this.Hide();
            familia.Show();
        }

        private void lnkCultura_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void lnkLiberdade_Click(object sender, EventArgs e)
        {
            Liberdade liberdade = new Liberdade();
            this.Hide();
            liberdade.Show();
        }

        /*private void lnkEducacao_Click(object sender, EventArgs e)
        {
            Home educacao = new Home();
            this.Hide();
            educacao.Show();
        }*/
    }
}
