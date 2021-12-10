using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Forma
    {
        // Propriedades
        public int X { get; private set; }
        public int Y { get; set; }
        public int Altura { get; set; }
        public int Largura { get; set; }
        public int Raio { get; set; }

        // Métodos
        public virtual void Desenhar()
        {
            Console.WriteLine("Preparando-se para desenhar");
        }
        public virtual void Area()
        {
            int area = Largura * Altura;
        }
    }

    public class Circulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um Círculo.");
        }
        public override void Area()
        {
            double area = 3.14 * (Raio * Raio);
            Console.WriteLine ("Area Círculo " + area);
        }
    }

    public class Retangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um Retângulo.");
        }
        public override void Area()
        {
            base.Area();
        }
    }

    public class Triangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um Triângulo");
        }
        public override void Area()
        {
            int area = (Largura * Altura) / 2;
            Console.WriteLine("Area Triãngulo " + area);
        }
    }
}
