using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeHospedagem.Models
{
    internal class Suite
    {
        private int _idSuite { get; }
        private string _tipoSuite { get; }
        private int _capacidade { get; }
        private decimal _valorDiaria { get; }

        public Suite(int idSuite, string tipoSuite, int capacidade, decimal valorDiaria) {
        
            _idSuite = idSuite;
            _tipoSuite = tipoSuite;
            _capacidade = capacidade;
            _valorDiaria = valorDiaria; 
        }

        public string SuiteToString() => 
                $"\nDados da suite:\n" +
                $"# {_idSuite} \t| " +
                $"Tipo: {_tipoSuite} \t| " +
                $"Capacidade:  {_capacidade} \t| " +
                $"Valor Diária: R$ {_valorDiaria}\n";

        public decimal GetValorDiaria() => _valorDiaria;
        public int GetCapacidade() => _capacidade;
        public string GetTipoSuite() => _tipoSuite;

    }
}
