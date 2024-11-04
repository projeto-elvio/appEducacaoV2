namespace appEducacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Protecao liberdade = new Protecao();
            this.Hide();
            liberdade.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        //cultura

        private void lnkLiberdade_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Protecao protecao = new Protecao();
            this.Hide();
            protecao.Show();
        }

        private void lbl_Educacao_Click(object sender, EventArgs e)
        {

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

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void link_questionario_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Questionario questionario = new Questionario();
            this.Hide();
            questionario.Show();
        }

        private void lblAcessoEducacao_Click(object sender, EventArgs e)
        {

        }
    }
}
