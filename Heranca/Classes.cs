using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Hommo_Sapiens
    {
        // O método virtual pode ser sobrescrito, ou não, pelas classes herdeiras
        public virtual void Comunicar()
        {
            Console.WriteLine("Hommo_Sapiens.Comunicar");
        }
        public virtual void Alimentar()
        {
            Console.WriteLine("Hommo_Sapiens.Alimentar");
        }
    }
    class Humano : Hommo_Sapiens
    {
        public override void Comunicar()
        {
            Console.WriteLine("Humano.Comunicar");
        }
        public sealed override void Alimentar() // A partir desse momento não haverá mais herança desse método
        {
            Console.WriteLine("Humano.Alimentar");
        }
    }
    class Homem : Humano
    {
        public override void Comunicar()
        {
            Console.WriteLine("Homem.Comunicar");
        }
        // Um erro foi apontado, pois o método Alimentar foi selado (sealed) na classe Humano
        //public override void Alimentar()
        //{
        //    Console.WriteLine("Homem.Alimentar");
        //}
    }

}
