using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagem.Models
{
    public class Suite
    {
        public Suite(string tipo, int capacidade, decimal valorDiaria)
        {
            Tipo = tipo;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
        private string _tipo;
        public string Tipo
        {
            get => _tipo;
            set
            {
                if (value == "" || value == null)
                    throw new ArgumentNullException("Informe o tipo da suíte.");

                _tipo = value.ToUpper();
            }
        }
        private int _capacidade;
        public int Capacidade
        {
            get => _capacidade;
            set 
            {
                if (value <= 0)
                    throw new ArgumentException("A suíte deve comportar ao menos 1 pessoa");

                _capacidade = value;
            }
        }
        private decimal _valorDiaria;
        public decimal ValorDiaria
        {
            get => _valorDiaria;
            set => _valorDiaria = value;
        }
    }
}