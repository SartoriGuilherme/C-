using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Aluno
{
    public class Pessoa
    {
        private string nome;
        private int idade;

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public string Nome
        {
            get { return nome; }
            set
            {
                if (value != null)
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
                if (value > 0)
                {
                    idade = value;
                }
                else
                {
                    throw new ArgumentException("Idade não pode ser negativo ou zero");
                }
            }
        }
        public virtual void ExibirNota()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }

        public class Aluno : Pessoa
        {
            private int nota { get; set; }

            public Aluno(string nome, int idade, int nota) : base(nome, idade)
            {
                this.Nota = nota;
            }

            public int Nota
            {
                get { return nota; }
                set
                {
                    if (value >= 0 && value <= 10)
                    {
                        nota = value;
                    }
                    else
                    {
                        throw new ArgumentException("Nota deve estar entre 0 e 10");
                    }
                }
            }

            public override void ExibirNota()
            {
                base.ExibirNota();
                Console.WriteLine($"A nota do aluno é: {Nota}");
            }

        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Pessoa aluno1 = new Aluno("Lucas Scotti", 30, 8);

                aluno1.ExibirNota();
            }
        }
    }
}
