using Enums;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            QtdMovimentos = 0;
            Tab = tab;
        }

        public abstract bool[,] MovimentosPossiveis();

        public bool PodeMoverPara(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for(int i=0; i < Tab.Linhas; i++)
            {
                for (int j = 0; j < Tab.Colunas; j++)
                {
                    if (mat[i,j] == true) {
                        return true;
                    }
                }
            }
            return false;
        }
       

        public void IncrementarQtdMovimentos()
        {
            QtdMovimentos++;
        }

        public void DecrementarQtdMovimentos()
        {
            QtdMovimentos--;
        }
    }
}
