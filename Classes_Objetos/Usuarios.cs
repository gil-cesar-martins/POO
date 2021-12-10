using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objetos
{
    internal class Usuarios
    { 
        // Atributos
        public int id;
        public string nome;
        public string plano;

        // Métodos
        public void exibir()
        {
            Console.WriteLine("Este é o nosso usuário " + id + " se se chama " + nome);
        }
    }
}
