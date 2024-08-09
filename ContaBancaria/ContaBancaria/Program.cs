using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ContaBancaria
{
    public class Conta
    {
        private string titular;
        private int numero;

        public Conta(string titular, int numero)
        {
            this.Titular = titular;
            this.Numero = numero;
        }

        public string Titular
        {
            get { return titular; }
            set
            {
                if (value != null)
                {
                    titular = value;
                }
            }
        }

        public int Numero
        {
            get { return numero; }
            set
            {
                if (value > 0)
                {
                    numero = value;
                }
                else
                {
                    throw new ArgumentException("Idade não pode ser negativo ou zero");
                }
            }
        }
    
        

        public virtual void ExibirSaldo()
        {
            Console.WriteLine($"Titular: {Titular}, Numero da Conta: {Numero}");
        }
    }
 
    public class ContaBancaria : Conta
    {
        private int saldo;

        public ContaBancaria(string titular, int numero, int saldo) : base(titular, numero)
        {
            this.Saldo = saldo;
        }
        public int Saldo
        {
            get { return saldo; }
            set
            {
                if (value > 0)
                {
                    saldo = value;
                }
                else
                {
                    throw new ArgumentException("saldo não pode ser negativo ou zero");
                }
            }
        }

            public override void ExibirSaldo()
        {
            base.ExibirSaldo();
            Console.WriteLine($"O saldo da Conta é: {Saldo}");
        }
    }



        internal class Program
        {
            static void Main(string[] args)
            {
            }
        }
}

