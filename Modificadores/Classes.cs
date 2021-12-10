using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    class Teste
    {
        // Atributos
        // public string nome;
        // public string sobrenome;

        public string endereco;
        public string referencia;

        // Métodos
        // public void Metodo1() { }
        // public void Executar() { }
    }
    class Humano
    {
        protected string usuario;  // O modificador de acesso protected pertmite a mudança de um método e atributo somente entre as classes e não na instanciação
        protected string sobrenome = "Gabriel";
        private string plano = "Ouro";
        public void Exibir()
        {
            Console.WriteLine(plano);
        }
    }
    class Homem : Humano
    {
        public void Metodo()
        {
            sobrenome = "Giovanne";
            usuario = "Fulano";
            Console.WriteLine(usuario+" "+sobrenome);
            
            // sobrenome = ""; veja que o atributo sobrenome não foi aceito, pois é privado pela classe Humano
        }
    }
}
