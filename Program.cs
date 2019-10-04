using System;
using tabuleiro;
using xadrez;
using Enums;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.ColocarPeca(new Torre(Cor.Branca, tab), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 5));
            tab.ColocarPeca(new Rei(Cor.Branca, tab), new Posicao(5, 0));
            tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(6, 4));

            Tela.ImprimirTabuleiro(tab);

            Console.WriteLine(pos.ToPosicao());

            Console.WriteLine(pos);
        }
        
    }
}
