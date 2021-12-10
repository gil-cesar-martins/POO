using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_Construtor
{
    internal class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int anoNascimento;
        public int idade;

        // O método construtor segue esse padrão: 
        // é public, possui o mesmo nome da classe a que se refere e não retorna valor
        public Pessoa()
        {
            nome = "Desconhecido";
            sobrenome = "Nenhum";
            anoNascimento = 0;
            idade = 0;
        }

        // Podemos realizar uma sobrecarga (overloading) de um método construtor, no caso podemos mudar a assinatura (parâmetros)
        public Pessoa(string nome, string sobrenome, int anoNascimento)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.anoNascimento = anoNascimento;
            idade = Idade();
        }

        private int Idade()
        {
            return 2021 - anoNascimento;
        }

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.anoNascimento = 2003;
            idade = Idade();
        }

    }
}
