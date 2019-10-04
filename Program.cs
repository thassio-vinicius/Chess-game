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

            Console.WriteLine(pos.ToPosicao());

            Console.WriteLine(pos);
        }
        
    }
}
