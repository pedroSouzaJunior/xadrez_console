﻿using System;
using tabuleiro;
using xadrez;
namespace xadrez_console {
    class Program {
        static void Main(string[] args) {

            
            try {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
                tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 3));
                tab.colocarPeca(new Rei(Cor.Preta, tab), new Posicao(2, 4));
                tab.colocarPeca(new Torre(Cor.Branca, tab), new Posicao(3, 5));
                tab.colocarPeca(new Torre(Cor.Branca, tab), new Posicao(3, 6));
                tab.colocarPeca(new Rei(Cor.Branca, tab), new Posicao(3, 4));

                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e){
                Console.WriteLine(e.Message);
            }
            
            /*
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());
            */
            Console.ReadLine();
        }
    }
}
