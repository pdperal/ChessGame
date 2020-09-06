﻿using System;
using System.Threading;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);
            
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preto), new Posicao(0, 0));
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preto), new Posicao(1, 3));
            tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preto), new Posicao(2, 4));

            Tela.ImprimirTabuleiro(tabuleiro);
            Console.ReadLine();
        }
    }
}
