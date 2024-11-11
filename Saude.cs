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
    public partial class Saude : Form
    {
        public Saude()
        {
            InitializeComponent();
        }

        private void SAUDEE_Load(object sender, EventArgs e)
        {

        }

        private void lbl_home_Click(object sender, EventArgs e)
        {

        }

        private void lnkSaude_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Familia familia = new Familia();
            this.Hide();
            familia.Show();
        }

        private void lnkCultura_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cultura cultura = new Cultura();
            this.Hide();
            cultura.Show();
        }

        private void lnkLiberdade_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Protecao protecao = new Protecao();
            this.Hide();
            protecao.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void lnkEsportes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Esportes esportes = new Esportes();
            this.Hide();
            esportes.Show();
        }

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
