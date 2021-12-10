using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    internal class Program
    {
        static void Main(string[] args)
        {   // No modificador de acesso public podemos instanciar os métodos e atributos em um objeto
            Teste t = new Teste();
            // t.nome = "";
            // t.sobrenome = "";
            // t.Executar();
            // t.Metodo1();
            

            // No modificador de acesso private, os métodos e atributos ficam privados somente para a classe 
            Homem h = new Homem();
            h.Exibir();
            Console.WriteLine();
            h.Metodo();


            Console.ReadKey();
            

        }
    }
}
