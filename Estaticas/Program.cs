using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Não precisaremos instanciar um objeto pois agora a classe é estática
            // Matematica m = new Matematica(); 

            // É só chamar a classe e selecionar os métodos e atributos desejados
            #region Classe Estática

            //Matematica.taxa = 10;

            //int valor1 = Matematica.Adicionar(200);
            //int valor2 = Matematica.Diminuir(200);

            //Console.WriteLine("Valor 1: " + valor1);
            //Console.WriteLine("Valor 2: " + valor2);

            #endregion

            #region Membros Estáticos

            Pessoa.maioridade = 21;

            Pessoa p1 = new Pessoa();
            p1.nome = "Gil";
            p1.idade = Pessoa.CalcularIdade(1987);

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);
            Console.WriteLine(Pessoa.maioridade);
            
            #endregion

            Console.ReadKey();
        }
    }
}
