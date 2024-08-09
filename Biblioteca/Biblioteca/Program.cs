using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro();
            livro.Autor = "Lewis";
            livro.Titulo = "Cronicas de Narnia";

            Livro livro2 = new Livro();
            livro2.Autor = "Leoncio";
            livro2.Titulo = "Guia de T.I";

            Livro livro3 = new Livro();
            livro3.Autor = "Fallenzao";
            livro3.Titulo = "Perfeitinha do Professor";


            Biblioteca biblioteca = new Biblioteca();
            biblioteca.Adicionar(livro);
            biblioteca.Adicionar(livro2);
            biblioteca.Adicionar(livro3);

            biblioteca.Consultar();
            biblioteca.SearchBook("Cronicas de Narnia");
        }

    }

    class Livro
    {
        public string Autor;
        public string Titulo;
    }


    class Biblioteca
    {
        List<Livro> livros = new List<Livro>();

        public void Adicionar(Livro livro)
        {
            livros.Add(livro);
        }
        public void Consultar()
        {
            foreach (var livro in livros)
            {
                Console.WriteLine(livro.Titulo);
            }
        }

        public void SearchBook(string titulo)
        {
            foreach (var livro in livros)
            {
                if (titulo == livro.Titulo)
                {
                    Console.WriteLine("Livro encontrado ");
                }
            }


        }
    }
}
        

