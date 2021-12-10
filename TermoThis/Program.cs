using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermoThis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acessar a = new Acessar();

            Console.Write("Digite a senha: ");
            string password = Console.ReadLine();
            if (a.Login(password))
            {
                Console.WriteLine("Acesso liberado !");
            }
            else
            {
                Console.WriteLine("Acesso negado!");
            }
        }
    }
}
