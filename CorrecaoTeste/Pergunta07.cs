using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrecaoTeste {
   partial class Torneio {
      public void AddEscola(string nomeEscola) {
         this.Escolas.Add(new Escola() { Nome = nomeEscola, });
      }
   }
}
