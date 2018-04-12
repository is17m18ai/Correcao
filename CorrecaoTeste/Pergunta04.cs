using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrecaoTeste {
   partial class Jogador {
      public Jogador(string email,string nome,string morada,DateTime dataNascimento,Equipa equipa) {
         this.Email = email;
         this.Nome = nome;
         this.Morada = morada;
         this.DataNascimento = dataNascimento;
         this.Equipa = equipa;
      }
   }
   partial class JogadorLoL {
      public JogadorLoL(string riotId, string email, string nome, string morada, DateTime dataNascimento, Equipa equipa)
      :base(email,nome,morada,dataNascimento,equipa)   
      {
         this.RiotId = riotId;
      }
      public JogadorLoL(string riotId,Convite convite,string morada,DateTime dataNascimento)
      :this(riotId,convite.Email,convite.Nome,morada,dataNascimento,convite.Equipa)
         {
         if (convite.Equipa.Jogo != Jogo.LoL) {
            Console.Error.WriteLine("Jogo inválido!");
         }
      }
   }
   partial class JogadorCS {
      public JogadorCS(string steamNickName, string email, string nome, string morada, DateTime dataNascimento, Equipa equipa)
      : base(email, nome, morada, dataNascimento, equipa) {
         this.SteamNickName = steamNickName;
      }
      public JogadorCS(string steamNickName, Convite convite, string morada, DateTime dataNascimento)
      : this(steamNickName, convite.Email, convite.Nome, morada, dataNascimento, convite.Equipa) {
         if (convite.Equipa.Jogo != Jogo.GO) {
            Console.Error.WriteLine("Jogo inválido!");
         }
      }
   }
}
