using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classes e Objetos
            //MinhaClasse mClasse = new MinhaClasse();
            //MinhaClasse m2 = null;

            //OutraClasse outra = new OutraClasse();
            //OutraClasse outra2 = outra;
            #endregion

            #region Atributos das Classes
            Pessoa p1 = new Pessoa();
            p1.nome = "Gil";
            p1.sobrenome = "César";
            p1.anoNascimento = 1987;

            Pessoa p2 = new Pessoa()
            {
                nome = "Raul",
                sobrenome = "Martins",
                anoNascimento = 2023
            };

            Usuarios user1 = new Usuarios()
            {
                nome = "Felixberto",
                id = 1,
                plano = "Premium"
            };

            Usuarios user2 = new Usuarios()
            {
                nome = "Alonzo",
                id = 2,
                plano = "Free"
            };

            

            Console.WriteLine("Pessoa 1: " + p1.nome);
            Console.WriteLine("Pessoa 1: " + p1.sobrenome);
            Console.WriteLine("Pessoa 1: " + p1.anoNascimento);
            p1.Cumprimentar();

            Console.WriteLine();

            Console.WriteLine("Pessoa 2: " + p2.nome);
            Console.WriteLine("Pessoa 2: " + p2.sobrenome);
            Console.WriteLine("Pessoa 2: " + p2.anoNascimento);
            p2.Cumprimentar();

            Console.WriteLine();

            Console.WriteLine("Usuário 1: " + user1.nome);
            Console.WriteLine("Usuário 1: " + user1.id);
            Console.WriteLine("Usuário 1: " + user1.plano);
            user1.exibir();

            Console.WriteLine();
            Console.WriteLine("Usuário 2: " + user2.nome+" ID: "+ user2.id +" Plano: "+user2.plano);
            user2.exibir();

            Console.ReadKey();
            #endregion


        }
    }
}
