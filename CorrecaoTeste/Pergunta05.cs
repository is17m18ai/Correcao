using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrecaoTeste {
   partial class Torneio {
      private const int MAX_EQUIPAS = 8;
      public IEnumerable<EquipaCS> EquipasCS { get=>eCS; }
      private ICollection<EquipaCS> eCS;
      ICollection<Escola> Escolas { get; }
      public IEnumerable<EquipaLoL> EquipasLoL { get => eLOL; }
      private ICollection<EquipaLoL> eLOL;
      public Torneio() {
         eCS = new List<EquipaCS>();
         eLOL = new List<EquipaLoL>();
         Escolas = new List<Escola>();
      }
   }
}
