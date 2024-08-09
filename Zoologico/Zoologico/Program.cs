using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoologico.classes;

namespace Zoologico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ZoologicoClass zoologico = new ZoologicoClass();

            while (true)
            {
                Console.WriteLine("Selecione a Opção: ");
                Console.WriteLine("1. Adicionar Mamífero");
                Console.WriteLine("2. Adicionar Ave");
                Console.WriteLine("3. Adicionar Reptil");
                Console.WriteLine("4. Listar animais");
                Console.WriteLine("5. Alimentar animais");
                Console.WriteLine("6. Cuidar dos animais");
                Console.WriteLine("7. Adicionar tratador de mamíferos");
                Console.WriteLine("8. Adicionar tratador de aves");
                Console.WriteLine("9. Listar Tratadores");
                Console.WriteLine("10. Sair");


                string opcao = Console.ReadLine();

                if(opcao == "10")
                {
                    break;
                }

                switch(opcao)
                {
                    case "1":
                        Console.WriteLine("Digite o nome do mamífero: ");
                        string nomeMamifero = Console.ReadLine();

                        Console.WriteLine("Digite a idade do mamífero: ");
                        int idadeMamifero = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o tipo de pelo do animal: ");
                        string tipoDePelo = Console.ReadLine();

                        Mamifero mamifero = new Mamifero(nomeMamifero, idadeMamifero, tipoDePelo);

                        zoologico.AdicionarAnimal(mamifero);

                        break;

                    case "2":
                        Console.WriteLine("Digite o nome do Ave: ");
                        string nomeAve = Console.ReadLine();

                        Console.WriteLine("Digite a idade do Ave: ");
                        int idadeAve = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a envergadura das asas do animal: ");
                        double envergadura = double.Parse(Console.ReadLine());

                        Ave ave = new Ave(nomeAve, idadeAve, envergadura);

                        zoologico.AdicionarAnimal(ave);

                        break;


                    case "3":
                        Console.WriteLine("Digite o nome do Reptil: ");
                        string nomeReptil = Console.ReadLine();

                        Console.WriteLine("Digite a idade do Reptil: ");
                        int idadeReptil = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o tipo de escama do Reptil: ");
                        string tipoEscama = Console.ReadLine();

                        Reptil reptil = new Reptil(nomeReptil, idadeReptil, tipoEscama);

                        zoologico.AdicionarAnimal(reptil);

                        break;

                    case "4":
                         zoologico.ListarAnimais();

                    break;

                    case "5":
                         zoologico.AlimentarAnimais();

                         break;


                    case "6":
                        zoologico.CuidarAnimais();
                        
                        break;

                    case "7":
                        Console.WriteLine("Digite o nome do tratador: ");
                        string nomeTratadorMamiferos = Console.ReadLine();

                        Console.WriteLine("Digite a especialidade do tratador: ");
                        string especialidadeMamiferos = Console.ReadLine();

                        TratadorMamiferos tratadorMamiferos = new TratadorMamiferos(nomeTratadorMamiferos, especialidadeMamiferos);

                        zoologico.AdicionarTratador(tratadorMamiferos);

                        break;

                    case "8":
                        Console.WriteLine("Digite o nome do tratador: ");
                        string nomeTratadorAves = Console.ReadLine();

                        Console.WriteLine("Digite a especialidade do tratador: ");
                        string especialidadeAves = Console.ReadLine();

                        TratadorAves tratadorAves = new TratadorAves(nomeTratadorAves, especialidadeAves);

                        zoologico.AdicionarTratador(tratadorAves);

                        break;

                    case "9":
                        zoologico.ListarTratadores();

                        break;

                    default:
                        Console.WriteLine("Opção Desconhecida!");

                            break;
                              
                }       
            }
        }
    }
}
