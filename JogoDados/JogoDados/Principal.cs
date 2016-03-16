using System;
using System.Windows.Forms;

namespace JogoDados
{
    public partial class Principal : Form
    {
        Jogador jogador1;
        Jogador jogador2;
        Timer timer;

        public Principal()
        {
            InitializeComponent();
            jogador1 = new Jogador();
            jogador2 = new Jogador();
            timer = null;
        }

        private void btnJogarDado1_Click(object sender, EventArgs e)
        {
            jogarDado(jogador1, lblDado1);
        }

        private void btnJogarDado2_Click(object sender, EventArgs e)
        {
            jogarDado(jogador2, lblDado2);
        }

        private void jogarDado(Jogador jog, Label lbl)
        {
            if (timer == null)
            {
                Jogador jogador = jog;
                Label lblDado = lbl;

                jogador.jogar();
                lblDado.Text = jogador.valorDado().ToString();
                atualizarPlacar();
            }
            else
            {
                MessageBox.Show("Você deve esperar 2 segundos entre cada rodada.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void atualizarPlacar()
        {
            if (jogador1.jaJogou() && jogador2.jaJogou())
            {
                criarTimer(2000);

                if (jogador1.valorDado() > jogador2.valorDado())
                {
                    jogador1.ganharJogada();
                    lblPlacarJogador1.Text = jogador1.valorPlacar().ToString();
                }

                if (jogador1.valorDado() < jogador2.valorDado())
                {
                    jogador2.ganharJogada();
                    lblPlacarJogador2.Text = jogador2.valorPlacar().ToString();
                }
            }

            if (jogador1.valorPlacar() == 2 || jogador2.valorPlacar() == 2)
            {
                int numJogador = 0;

                if (jogador1.valorPlacar() == 2)
                {
                    numJogador = 1;
                }

                if (jogador2.valorPlacar() == 2)
                {
                    numJogador = 2;
                }

                MessageBox.Show("O Jogador " + numJogador + " venceu a partida!", "Temos um vencedor!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                jogador1.resetarPlacar();
                jogador2.resetarPlacar();

                lblPlacarJogador1.Text = jogador1.valorPlacar().ToString();
                lblPlacarJogador2.Text = jogador2.valorPlacar().ToString();
            }
        }

        private void criarTimer(int mseg)
        {
            timer = new Timer();
            timer.Interval = mseg;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (jogador1.jaJogou() && jogador2.jaJogou())
            {
                jogador1.resetarJogada();
                jogador2.resetarJogada();

                lblDado1.Text = jogador1.valorDado().ToString();
                lblDado2.Text = jogador2.valorDado().ToString();

                timer.Dispose();
                timer = null;
            }
        }
    }
}
