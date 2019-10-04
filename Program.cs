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
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 3));
                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(2, 4));
                tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(0, 0));

                Tela.ImprimirTabuleiro(tab);

            }

            catch(TabuleiroException e)
            {
                Console.WriteLine("ERRO: " + e.Message);
            }
            Console.ReadLine();
        }
    }
}
