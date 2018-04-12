using System;

namespace CorrecaoTeste {
   class Program {
      static Torneio torneio = new Torneio();
      static void Main(string[] args) {
         //TODO: implementar todas as funcoesa abaixo
         LerCincoEscolas();
         InscreverEquipas(Jogo.LoL, 10);
         InscreverEquipas(Jogo.GO, 5);
         AceitarConvites();
         EscreverEquipasAceites(Jogo.GO);
         EscreverEquipasAceites(Jogo.LoL);
      }

        private static void InscreverEquipas(Jogo Lol, Jogo Go int v)
        {
            torneio.AddEquipa(Equipa);
        }

        static void LerCincoEscolas() {
         for (int j = 0; j < 5; j++) {
            string nomeEscola = Console.In.ReadLine();
            torneio.AddEscola(nomeEscola);
         }
      }
        
   }
}
