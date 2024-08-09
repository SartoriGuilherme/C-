using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico.classes
{
    public abstract class Tratador
    {
        public string Nome {  get; set; }
        public string Especialidade { get; set; }

        public Tratador(string nome, string especialidade) 
        {
            Nome = nome;
            Especialidade = especialidade;
        }   

    }
}
