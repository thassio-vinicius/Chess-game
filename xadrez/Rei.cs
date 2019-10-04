using tabuleiro;
using Enums;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro tab)
            : base(cor, tab)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
