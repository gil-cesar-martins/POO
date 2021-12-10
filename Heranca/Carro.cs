using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Carro : Veiculo
    {
        public int VelocidadeMaxima { get; set; }

        public void LigarMotor()
        {
            Console.WriteLine("Ligou o motor!");
        }

       // Os métodos herdados da classe Veiculo estão sendo implementados aqui.
       // Como a classe Veiculo é abstrata, os seus métodos podem ser sobrescritos, por isso usamos o override
        public override void Acelerar()
        {
            Console.WriteLine("Acelerou!");
        }

        public override void Parar()
        {
            Console.WriteLine("Pisou no freio.");
        }
    }
}
