﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    sealed class Bicileta : Veiculo
    {
        public void Pedalar()
        {
            Console.WriteLine("Pedalou!");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerou a bike na descida!");
        }

        public override void Parar()
        {
            Console.WriteLine("Apertou o freio traseiro da bike.");
        }


    }
}
