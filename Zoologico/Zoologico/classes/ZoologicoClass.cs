using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoologico.Interface;

namespace Zoologico.classes
{
    public class ZoologicoClass
    {
        private List<Animal> animais = new List<Animal>();
        private List<Tratador> tratadores = new List<Tratador>();

        public void AdicionarAnimal(Animal animal)
        {
            animais.Add(animal);
            Console.WriteLine($"{animal.Nome} foi adicionado");
        }

        public void AdicionarTratador(Tratador tratador)
        {
            tratadores.Add(tratador);
            Console.WriteLine($"{tratador.Nome} foi adicionado");
        }

        public void ListarAnimais()
        {
            if ( animais.Count > 0 )
            {
                Console.WriteLine("Animais no Zoológico: ");
                foreach (Animal animal in animais)
                {
                    animal.EmitirSom();
                    Console.WriteLine($"Nome: {animal.Nome}, Idade: {animal.Idade}");
                }
            }
            else
            {
                Console.WriteLine("A lista está vazia");
            }
        }

        public void ListarTratadores()
        {
            if (animais.Count > 0 )
            {
                Console.WriteLine("Tutores no Zoológico: ");
                foreach (Tratador tratador in tratadores)
                {
                    Console.WriteLine($"Nome: {tratador.Nome}, Especialidae {tratador.Especialidade}");
                }
            }
        }

        public void AlimentarAnimais()
        {
            Console.WriteLine("Alimentando os Animais...");
            foreach(Animal animal in animais)
            {
                if(animal is IAlimentavel alimentavel)
                {
                    alimentavel.Alimentar();
                }
            }
        }

        public void CuidarAnimais()
        {
            Console.WriteLine("Os animais estão sendo cuidados...");
            foreach (Animal animal in animais)
            { 
                if(animal is ICuidavel cuidavel )
                {
                    cuidavel.Cuidar();
                }
            }
        }
    }
}
