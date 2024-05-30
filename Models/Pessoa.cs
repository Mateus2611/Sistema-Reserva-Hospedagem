using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagem.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        public string Nome 
        {
            get => _nome;
            set 
            {
                if (value == "" || value == null)
                    throw new ArgumentException("O nome não pode ser vazio");
                
                _nome = value.ToUpper();
            }
        }

        private string _sobrenome;
        public string Sobrenome
        {
            get => _sobrenome;
            set 
            {
                if (value == "" || value == null)
                    throw new ArgumentException("O sobrenome não pode ser vazio.");
                
                _sobrenome = value.ToUpper();
            
            }
        }

    }
}