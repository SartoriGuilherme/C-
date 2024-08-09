using System;

namespace OlaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Aparicio";
            pessoa.Idade = 19;

            pessoa.Apresentar();

            Console.WriteLine("Olá Mundo C#");
        }
    }
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public void Apresentar() 
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
        }
    }


}

