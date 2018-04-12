using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrecaoTeste {

   partial class EquipaLoL : Equipa 
      {
      public EquipaLoL(string nome, Escola escola, Capitao capitao)
         :base(nome,escola,capitao) {}
      public override Jogo Jogo => Jogo.LoL; 
   }

   partial class EquipaCS : Equipa {
      public EquipaCS(string nome, Escola escola, Capitao capitao)
         : base(nome, escola, capitao) {}
      public override Jogo Jogo => Jogo.GO;
   }

}
