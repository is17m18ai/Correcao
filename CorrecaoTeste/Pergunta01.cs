using System;
using System.Collections.Generic;

namespace CorrecaoTeste {
   enum Jogo { LoL, GO }
   partial class Escola {
      public string Nome { get; set; }
      public ICollection<Equipa> Equipas { get; } = new List<Equipa>();
   }
   abstract partial class Equipa {
      private int id;
      private string nome;
      public int Id { get => id; }
      public string Nome { get => nome; }
      public Escola Escola { get; set; }
      private ICollection<IJogador> jogadores = new List<IJogador>();

      
      public IEnumerable<IJogador> Jogadores { get => jogadores; }
      public virtual Jogo Jogo { get; }
   }
   partial class Convite {
      public string Email { get; set; }
      public Guid Id { get; } = Guid.NewGuid();
      public string Nome { get; }
      public Equipa Equipa { get; }
      public IJogador Jogador { get; }
   }
   interface IJogador {
      DateTime DataNascimento { get; }
      string Email { get; }
      string Id { get; }
      int Idade { get; }
      bool IsCaptain { get; }
      string Morada { get; set; }
      string Nome { get; set; }
      Convite Convite { get; }
      Equipa Equipa { get; }
   }
}
