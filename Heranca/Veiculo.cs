using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{   // Métodos abstratatos só podem ser gerados de classes abstratas.
    abstract class Veiculo
    {
        // Aqui usamos as propriedades Cor e Marca como campos e assim elas recebem e configuram
        public string Cor { get; set; } 
        public string Marca { get; set; }

        // Métodos
        // Esses métodos abstratos não podem ter implementação, pois se espera que as classes herdeiras os implementem.
        public abstract void Acelerar();

        public abstract void Parar();
    }
}
