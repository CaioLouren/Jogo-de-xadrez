using System;
using System.Globalization;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab;
            tab = new Tabuleiro(8, 8);

            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 1));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 2));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 3));
            tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(5, 2));

            Tela.ImprimirTabuleiro(tab);
            Console.ReadLine();
        }
    }
}
