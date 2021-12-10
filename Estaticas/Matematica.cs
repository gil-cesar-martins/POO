using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{   // Devemos declarar a classe e também seus atributos e métodos como static
    static class Matematica
    {   
        // atributo
        public static int taxa;

        // métodos
        public static int Adicionar(int valor)
        {
            return valor + taxa;
        }

        public static int Diminuir(int valor)
        {
            return valor - taxa;
        }

    }
}
