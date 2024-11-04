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
    public partial class Familia : Form
    {
        public Familia()
        {
            InitializeComponent();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void lnkFamilia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkCultura_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void link_questionario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Questionario questionario = new Questionario();
            this.Hide();
            questionario.Show();
        }

        private void lnkLiberdade_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Protecao liberdade = new Protecao();
            this.Hide();
            liberdade.Show();
        }

        private void lnkEducacao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void lbl_home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }


        private void lnkLiberdade_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Protecao liberdade = new Protecao();
            this.Hide();
            liberdade.Show();
        }

        private void link_questionario_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void lnkCultura_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cultura cultura = new Cultura();
            this.Hide();
            cultura.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void lnkEsportes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Esportes esportes = new Esportes();
            this.Hide();
            esportes.Show();
        }

        private void lnkSaude_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Saude saude = new Saude();
            this.Hide();
            saude.Show();
        }
    }
}
