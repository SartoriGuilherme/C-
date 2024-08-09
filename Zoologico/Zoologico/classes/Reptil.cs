using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoologico.Interface;

namespace Zoologico.classes
{
    public class Reptil : Animal, IAlimentavel
    {
        public string TipoEscama {  get; set; }

        public Reptil(string nome, int idade, string tipoEscama) : base(nome, idade)
        {
            TipoEscama = tipoEscama;
        }

        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} faz som de Reptil");
        }

        public void Alimentar()
        { 
            Console.WriteLine($"{Nome} é Reptil e está sendo alimentado");
        }
    }


}
