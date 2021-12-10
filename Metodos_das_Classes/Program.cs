using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_das_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();
            #region Método simples
            //m.Cumprimentar();
            #endregion

            #region Métodos com Parâmetros
            //m.Somar(10,5);
            //m.Apresentar("Gil", 34);
            #endregion

            #region Passagem de parâmetros por valores e por referência

            //int valor1 = 100;
            //int valor2 = 100;

            //m.AumentarValor(valor1);
            //m.AumentarRef(ref valor2);

            //Console.WriteLine("Valor 1: "+ valor1);
            //Console.WriteLine("Valor 2: "+ valor2);

            #endregion

            #region Métodos com Retorno de valores

            //string nomeCompleto = m.MontaNome("Beto", "Barbosa");
            //int codigoChar = m.CodigoChar('a');
            //double pi = m.ValorPi();

            //Console.WriteLine(nomeCompleto);
            //Console.WriteLine(codigoChar);
            //Console.WriteLine(pi);

            #endregion

            #region Sobrecarga de Métodos

            //m.Cumprimentar();
            //m.Cumprimentar("Adalberto");
            //m.Cumprimentar("Janaína", 18);

            //bool res1 = m.Comparar(100, 50*2);
            //bool res2 = m.Comparar("Elvis", "elvis");

            //Console.WriteLine(res1);
            //Console.WriteLine(res2);

            #endregion

            Console.ReadKey();
        }
    }
}
