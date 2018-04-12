using System;

namespace CorrecaoTeste {
   partial class Equipa {
      public Equipa(string nome, Escola escola, Capitao capitao) {
         this.nome = nome;
         this.Escola = escola;
         this.jogadores.Add(capitao);
         this.id = contador;
         contador++;
      }
   }
   abstract partial class Jogador : IJogador {
      public Convite Convite { get; set; }
      public DateTime DataNascimento { get; }
      public string Email { get; }
      public abstract string Id { get; }
      public int Idade {
         get {
            int idadeAnos = DateTime.Now.Year - DataNascimento.Year;
            DateTime aux  = DataNascimento.AddYears(idadeAnos);
            if (DateTime.Now > aux) { return idadeAnos; } else { return idadeAnos - 1; }
         }
      }
      public virtual bool IsCaptain { get => false; }
      public string Morada { get; set; }
      public string Nome { get; set; }
      public Equipa Equipa { get; set; }
   }
   partial class JogadorLoL : Jogador {
      public override string Id { get => RiotId; }
      public string RiotId { get; set; }

   }
   partial class JogadorCS : Jogador {
      public override string Id { get => SteamNickName; }

      public string SteamNickName { get; set; }

   }
   partial class Capitao : Jogador {
      public Capitao(string nome,string id ,string email, string morada, DateTime dataNascimento, Equipa equipa) 
         : base(email, nome, morada,dataNascimento,equipa) {
         Id = id;
      }
      public Capitao() : base("", "", "", new DateTime(), null) {

      }

      public override string Id { get; }
      public override bool IsCaptain { get => true; }

   }
}
