using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Hotel
    {
        private int _capacidadeMaxima;
        private List<Reserva> _reservas = new List<Reserva>();

        public Hotel(int capacidadeMaxima)
        {
            _capacidadeMaxima = capacidadeMaxima;
        }

        public void CriarReserva(DateTime dataCheckIn, DateTime dataCheckOut, int quartos)
        {
            // Validações de entrada
            if(dataCheckIn >= dataCheckOut)
            {
                throw new ArgumentException("Data de CheckIn deve ser anteriro a data de CheckOut");
            }
            
            if(quartos > _capacidadeMaxima)
            {
                throw new InvalidOperationException("Número de quartos excedeu a capacidade máxima");
            }

            // Criar uma nova reserva e adicionar a lista
            var reserva = new Reserva(dataCheckIn, dataCheckOut, quartos);
            _reservas.Add(reserva);
        }

        public void CancelarReserva(DateTime checkIn, DateTime checkOut)
        {
            // Revome todas as reservas que coincidem com as datas
            _reservas.RemoveAll(r => r.DataCheckIn == checkIn && r.DataCheckOut == checkOut);
        }

        public List<Reserva> ObterReserva()
        { 
            return _reservas; 
        }

        public decimal CalcularValorTotalReserva(DateTime checkIn, DateTime checkOut, int quartos, decimal precoPorQuarto)
            {
            int noites = (checkOut - checkIn).Days;
            return noites * precoPorQuarto * quartos;
            }
        
           
    }
}

