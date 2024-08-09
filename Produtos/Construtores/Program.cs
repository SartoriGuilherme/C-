using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Construtores
{
    public class Produto 
    {
        private string nome { get; set; }
        private float preco { get; set; }
        private float quantidade { get; set; }

        public Produto(string nome, float preco, float quantidade)
        {
        this.Nome = nome;
        this.Preco = preco;
        this.Quantidade = quantidade;
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

        public float Preco
        {
            get { return preco; }
            set
            {
                if (value > 0)
                {
                    preco = value;
                }
                else
                {
                    throw new ArgumentException("Preco não pode ser negativo ou zero");
                }
            }
        }

        public float Quantidade
        {
            get { return quantidade; }
            set
            {
                if (value > 0)
                {
                    quantidade = value;
                }
                else
                {
                    throw new ArgumentException("Quantidade não pode ser negativa ou zero");
                }
            }
        }

        public virtual float CalcularValorTotal()
        {
            return Preco * Quantidade;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            try { 
                Produto produto = new Produto("Cadeira", 0, 29);
                { Console.WriteLine($"O produto {produto.Nome} custa {produto.CalcularValorTotal()}"); }
            }
            catch (ArgumentException ex)
            { Console.WriteLine("Utilize valores maiores que 0!" ); }
        }
    }
}
