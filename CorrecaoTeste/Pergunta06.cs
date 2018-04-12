using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrecaoTeste {
   partial class Torneio {

      public Jogador AceitarConvite(Jogo jogo, Guid id, string playerId, string morada, DateTime dataNacimento) {
         switch (jogo) {
            case Jogo.GO:
               foreach (var equ in EquipasCS) {
                  foreach (var con in equ.Convites) {
                     if (con.Id == id) {
                        return equ.AceitarConvite(con, playerId, morada, dataNacimento);
                     }
                  }
               }
               break;
            case Jogo.LoL:
               foreach (var equ in EquipasLoL) {
                  foreach (var con in equ.Convites) {
                     if (con.Id == id) {
                        return equ.AceitarConvite(con, playerId, morada, dataNacimento);
                     }
                  }
               }
               break;
         }
         return null;
      }
      public Guid Convidar(Capitao capitao, string email, string nome) {
         return capitao.Equipa.Convidar(nome, email);
      }
      public Capitao InscreverEquipa(Jogo jogo, string nomeEquipa, Escola escola) {

         if (jogo == Jogo.GO) {
            Capitao capitan = new Capitao();
            EquipaCS MyEquipaCS = new EquipaCS(nomeEquipa, escola, capitan);
            capitan.Equipa = MyEquipaCS;
            this.eCS.Add(MyEquipaCS);
            return capitan;
         } else if (jogo == Jogo.LoL) {
            Capitao capitan = new Capitao();
            EquipaLoL MyEquipaLOL = new EquipaLoL(nomeEquipa, escola, capitan);
            capitan.Equipa = MyEquipaLOL;
            this.eLOL.Add(MyEquipaLOL);
            return capitan;

         }
         return null;
      }

   }
   partial class Equipa {
      private static int contador = 1;


      private ICollection<Convite> ListaConvites = new List<Convite>();
      public IEnumerable<Convite> Convites { get => ListaConvites; }
      public Jogador AceitarConvite(Convite c, string playerId, string morada, DateTime dataNacimento) {
         if (ListaConvites.Contains(c)) {
            Jogador j;
            if (this.Jogo == Jogo.GO) {
               j = new JogadorCS(playerId, c, morada, dataNacimento);

            } else {
               j = new JogadorLoL(playerId, c, morada, dataNacimento);

            }
            jogadores.Add(j);
            ListaConvites.Remove(c);
            return j;

         }
         return null;
      }
      public Guid Convidar(string email, string nome) {
         if (jogadores.Count + ListaConvites.Count < 6) {
            Convite c = new Convite(nome, this);
            c.Email = email;
            ListaConvites.Add(c);
            return c.Id;
         } else {
            return Guid.Empty;
         }
      }

   }
   partial class Convite {
      public Convite(string nome, Equipa equipa) {
         this.Nome = nome;
         this.Equipa = equipa;
      }
   }
}
