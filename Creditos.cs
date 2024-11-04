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
        private void lnkLiberdade_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Liberdade liberdade = new Liberdade();
            this.Hide();
            liberdade.Show();
        }

        private void lbl_Educacao_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        //esportes

        //saude 

        private void link_questionario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Questionario questionario = new Questionario();
            this.Hide();
            questionario.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Creditos creditos = new Creditos();
            this.Hide();
            creditos.Show();
        }
    }
}
