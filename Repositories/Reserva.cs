using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagem.Models
{
    public interface IReserva
    {
        void CadastrarHospedes(List<Pessoa> hospedes);
        void CadastrarSuite(Suite suite);
        int ObterQuantidadeHospedes();
        decimal CalcularValorDiarias();
    }
    public class Reserva : IReserva
    {
        private List<Pessoa> _hospedes;
        public List<Pessoa> Hospedes 
        {
            get => _hospedes;
            set
            {
                if (value.Count() <= 0)
                    throw new ArgumentException("Ao menos 1 hospede deve ser cadastrado");
                
                _hospedes = value;
            }
        }
        private Suite _suite;
        public Suite Suite
        {
            get => _suite;
            set
            {
                if (_suite.Capacidade < _hospedes.Count())
                    throw new ArgumentException("A suíte selecionecionada não suporta a quantidade de hospedes atual, por favor esolha outra.");
                
                _suite = value;
            }
        }
        private int _diasReservados;
        public int DiasReservados
        {
            get => _diasReservados;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Deve-se reservar ao menos 1 dia.");
                
                _diasReservados = value;
            }
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            Hospedes = hospedes;
        }

        public void CadastrarSuite(Suite suite)
        {
            if (suite.Capacidade < _hospedes.Count())
                throw new ArgumentException("A capcidade da suíte não dave ser inferior à de hospedes.");

            _suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return _hospedes.Count();
        }

        public decimal CalcularValorDiarias()
        {
            decimal valor = _suite.ValorDiaria * _diasReservados;

            if (_diasReservados >= 10)
                valor -= (valor * (10 / 100));

            return valor;
        }
    }
}