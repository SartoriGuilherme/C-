using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresdeAcesso
{

    public class Pessoa
    {
        private string nome;
        private int idade;

        public Pessoa(string nome = "Nome não informado", int idade = 10)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
        public string Nome
        {
            get { return nome; }
            set
            {
                if (nome != null)
                {
                    nome = value;
                }
            }
        }

        public int Idade
        {
            get { return idade; }
            set
            {
                if (value > 0 && value < 140)
                {
                    idade = value;
                }
                else
                {
                    throw new ArgumentException("Idade não pode ser negativa");
                }
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Pessoa pessoa = new Pessoa("Raimundo", -1);
                { Console.WriteLine(pessoa.nome); }
                { Console.WriteLine(pessoa.idade); }
                //               try
                //               {
                //                   pessoa.Nome = "Raimundo";
                //                   pessoa.Idade = 100;
                //               }
                //               catch (Exception ex)
                //              {
                //                  Console.WriteLine(ex.Message);
                //               }
            }
        }
    }
}
    