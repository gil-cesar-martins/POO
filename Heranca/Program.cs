using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Parte 1

            //Carro c = new Carro();
            //Bicileta b = new Bicileta();
            //Caminhonete cam = new Caminhonete();

            //b.Marca = "Shimanu";
            //b.Cor = "Verde";
            //b.Pedalar();

            //c.Marca = "Hyundai";
            //c.Cor = "Preto";
            //c.LigarMotor();

            //cam.Marca = "Toyota";
            //cam.Cor = "Vermelha";
            //cam.LigarMotor();

            //Console.WriteLine("A bike é " + b.Cor + " e a marca é " + b.Marca);
            //Console.WriteLine("O carro é " + c.Cor +" e a marca é " + c.Marca);
            //Console.WriteLine("A caminhote é " + cam.Cor + " e a marca é " + cam.Marca);

            //Console.WriteLine();

            //b.Acelerar();
            //c.Acelerar();
            //cam.Acelerar();

            //Console.WriteLine();

            //b.Parar();
            //c.Parar();
            //cam.Parar();

            #endregion

            #region Parte 2

            Hommo_Sapiens a = new Hommo_Sapiens();
            Humano b = new Humano();
            Homem c = new Homem();

            Console.WriteLine("\nHommo Sapiens");
            a.Comunicar();
            a.Alimentar();
            Console.WriteLine("\nHumano");
            b.Comunicar();
            b.Alimentar();
            Console.WriteLine("\nHomem");
            c.Comunicar();
            c.Alimentar();

            #endregion

            Console.ReadKey();

        }
    }
}
