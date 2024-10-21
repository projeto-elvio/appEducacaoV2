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
    public partial class Questionario : Form
    {
        // Lista de perguntas
        private List<Pergunta> perguntas;
        private int perguntaAtual = 0;

        public Questionario()
        {
            InitializeComponent();
            CarregarPerguntas();
            CarregarPergunta();
        }

        private void CarregarPerguntas()
        {
            // Adicionando perguntas
            perguntas = new List<Pergunta>
        {
            new Pergunta { Texto = "Quando foi promulgado o Estatuto da Criança e do Adolescente (ECA)?", Opcoes = new[] { "1988", "1990", "1989", "1992" }, RespostaCorreta = 1 },
            new Pergunta { Texto = "Qual documento internacional assinado pelo Brasil em 1989 trata da proteção dos direitos das crianças e adolescentes?", Opcoes = new[] { "Declaração Universal dos Direitos Humanos", "Pacto de São José da Costa Rica", "Convenção sobre os Direitos da Criança (ONU)", "Protocolo Facultativo sobre a Criança" }, RespostaCorreta = 2 },
            new Pergunta { Texto = "Segundo a Constituição Federal de 1988, quem é responsável por assegurar os direitos das crianças e adolescentes?", Opcoes = new[] { "Apenas o Estado", "Apenas a família", "A família, a sociedade e o Estado", "ONGs e associações" }, RespostaCorreta = 2 },
            new Pergunta { Texto = "Qual dos seguintes direitos NÃO está incluído nos direitos fundamentais garantidos pelo ECA?", Opcoes = new[] { "Direito à vida", "Direito ao trabalho infantil", "Direito à saúde", "Direito à convivência familiar" }, RespostaCorreta = 1 },
            new Pergunta { Texto = "Qual órgão tem como função zelar pelo cumprimento dos direitos das crianças e adolescentes e aplicar medidas de proteção em caso de violação?", Opcoes = new[] { "Ministério da Justiça", "Polícia Federal", "Secretaria de Direitos Humanos", "Conselho Tutelar" }, RespostaCorreta = 3 },
            new Pergunta { Texto = "Qual é o papel da família, segundo o ECA, na proteção das crianças e adolescentes?", Opcoes = new[] { "Educar e cuidar, sendo o primeiro núcleo de proteção", "Apenas fornecer sustento financeiro", "Deixar a proteção a cargo do Estado", "Supervisionar apenas a educação formal" }, RespostaCorreta = 0 },
            new Pergunta { Texto = "Qual é um dos principais desafios que ainda persiste, mesmo com os avanços na proteção às crianças e adolescentes?", Opcoes = new[] { "Educação universal", "Políticas públicas para esportes", "Violência doméstica e exploração sexual", "Acesso à cultura" }, RespostaCorreta = 2 },
            new Pergunta { Texto = "Quais medidas são essenciais para garantir que as crianças e adolescentes em situação de vulnerabilidade sejam protegidas?", Opcoes = new[] { "Políticas públicas de inclusão social", "Apenas ajuda financeira", "Redução de impostos", "Aumento de campanhas publicitárias" }, RespostaCorreta = 0 },
            new Pergunta { Texto = "Quem atua na fiscalização do cumprimento da legislação e na responsabilização em casos de violação dos direitos das crianças e adolescentes?", Opcoes = new[] { "Conselhos Tutelares", "ONG's", "Ministério Público e Poder Judiciário", "Empresas privadas" }, RespostaCorreta = 2 },
            new Pergunta { Texto = "Para garantir o pleno desenvolvimento das crianças e adolescentes, o que é necessário da parte da sociedade?", Opcoes = new[] { "Indiferença aos problemas sociais", "Esperar que o Estado resolva tudo", "Redução da atuação de movimentos sociais", "Consciência e engajamento coletivo na defesa dos direitos" }, RespostaCorreta = 3 },
        };
        }

        private void CarregarPergunta()
        {
            var pergunta = perguntas[perguntaAtual];
            var num = (perguntaAtual + 1) + "-";
            lblPergunta.Text = pergunta.Texto;
            lblNumero.Text = num;
            radioButton1.Text = pergunta.Opcoes[0];
            radioButton2.Text = pergunta.Opcoes[1];
            radioButton3.Text = pergunta.Opcoes[2];
            radioButton4.Text = pergunta.Opcoes[3];
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int respostaSelecionada = -1;

            if (radioButton1.Checked) respostaSelecionada = 0;
            else if (radioButton2.Checked) respostaSelecionada = 1;
            else if (radioButton3.Checked) respostaSelecionada = 2;
            else if (radioButton4.Checked) respostaSelecionada = 3;

            if (respostaSelecionada == perguntas[perguntaAtual].RespostaCorreta)
            {
                MessageBox.Show("Resposta correta!");
            }
            else
            {
                MessageBox.Show("Resposta incorreta!");
            }

            perguntaAtual++;
            if (perguntaAtual < perguntas.Count)
            {
                CarregarPergunta();
            }
            else
            {
                MessageBox.Show("Teste concluído!");
            }

        }

        private void lnkEducacao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void lnkLiberdade_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Liberdade liberdade = new Liberdade();
            this.Hide();
            liberdade.Show();
        }

        private void lnkFamilia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Familia familia = new Familia();
            this.Hide(); 
            familia.Show();   
        }
    }
}

// Classe para perguntas
public class Pergunta
{
    public string Texto { get; set; }
    public string[] Opcoes { get; set; }
    public int RespostaCorreta { get; set; }
}