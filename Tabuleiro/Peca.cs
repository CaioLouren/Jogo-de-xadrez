using System;

namespace tabuleiro
{
    internal abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int QuantidadeDeMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }
        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.Tab = tab;
            this.cor = cor;
            this.QuantidadeDeMovimentos = 0;
        }

        public void IncrementarQtdDeMovimentos()
        {
            this.QuantidadeDeMovimentos++;
        }

        public abstract bool[,] MovimentosPossiveis();


    }
}
