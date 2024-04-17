using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeHospedagem.Models
{
    internal class Hospede
    {
        private int _idHospede { get;}


        private string _nomeHospede { get;}


        private string _sobrenomeHospede {  get;}


        public Hospede(int id, string nome,  string sobrenome)
        {
            _idHospede = id;
            _nomeHospede = nome;
            _sobrenomeHospede= sobrenome;
        }

        public string HospedeToString() => 
            $"\nDados do hóspede: \n" +
                $"# {_idHospede}\t| " +
                $"Nome: {_nomeHospede}\t| " +
                $"Sobrenome: {_sobrenomeHospede}";
    }
}
