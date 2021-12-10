using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermoThis
{
    internal class Acessar
    {
        // Atributo
        string senha = "abc123";

        // Método
        public bool Login(string senha)
        {
            return this.senha == senha;
        }
    }
}
