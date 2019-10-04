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

            PartidaDeXadrez partida = new PartidaDeXadrez();

            while (!partida.Terminada)
            {
                Console.Clear();
                Tela.ImprimirTabuleiro(partida.Tab);

                Console.Write("Origem: ");
                Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                Console.Write("Destino: ");
                Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                partida.ExecutarMovimento(origem, destino);
            }
            

           
        }
        
    }
}
