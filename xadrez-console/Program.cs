using System;
using System.Threading;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);

                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preto), new Posicao(0, 0));
                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preto), new Posicao(1, 3));
                tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preto), new Posicao(2, 4));

                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Branca), new Posicao(2, 5));
                tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Branca), new Posicao(7, 3));

                Tela.ImprimirTabuleiro(tabuleiro);
                Console.ReadLine();
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
