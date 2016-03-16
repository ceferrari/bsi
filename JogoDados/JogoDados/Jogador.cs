using System;

namespace JogoDados
{
    public class Jogador
    {
        private bool jogou;
        private int dado;
        private int placar;

        public Jogador()
        {
            this.jogou = false;
            this.dado = 0;
            this.placar = 0;
        }

        public bool jaJogou()
        {
            return this.jogou;
        }

        public int valorDado()
        {
            return this.dado;
        }

        public int valorPlacar()
        {
            return this.placar;
        }

        public void jogar()
        {
            this.jogou = true;
            this.dado = new Random().Next(1, 7);
        }

        public void ganharJogada()
        {
            this.placar++;
        }

        public void resetarJogada()
        {
            this.jogou = false;
            this.dado = 0;
        }

        public void resetarPlacar()
        {
            this.placar = 0;
        }
    }
}
