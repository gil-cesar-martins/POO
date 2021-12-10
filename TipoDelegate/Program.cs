using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class Program
    {
        // O tipo Delegate é uma variável global que armazena referências de
        // métodos de outras variáveis que possuem a mesma assinatura (parâmetros) e retorno  podendo ser usado de formas combinadas.
        delegate void Operacao(int num1, int num2);

        static void Main(string[] args)
        {
            Matematica m = new Matematica();

            Operacao conta = null;

            // Estamos atribuindo ao objeto conta os métodos pertencentes à classe Matemática por meio do objeto m
            conta += m.Somar;
            conta += m.Subtrair;
            conta += m.Multiplicar;
            conta += m.Dividir;

            conta(10, 2);

            Console.WriteLine();

            // Estamos excluindo esses dois métodos 
            conta -= m.Subtrair;
            conta -= m.Dividir;

            // Podemos alterar os parâmetros e mesmo assim seguirão o que foi estabelecido na classe
            conta(15, 3);

            Console.ReadKey();
        }
    }
}
