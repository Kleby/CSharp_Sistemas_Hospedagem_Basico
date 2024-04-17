using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeHospedagem.Models
{
    internal class Reserva
    {

        private int _idReserva { get; }

        private List<Hospede> _listaHospedes { get; } = new List<Hospede>();  

        private Suite Suite { get; set; }

        private int _diasReservados { get; }

        public Reserva( int id, int diasReservador) { 
            _idReserva = id;
            _diasReservados = diasReservador; 
        }

        public void CadastrarHospede(List<Hospede> novosHospedes)
        {

            string mensagem = (Suite.GetCapacidade() < novosHospedes.Count()) 
                   ? "Quantidade de hóspedes maior que a capacidade da suite!" 
                   : "Hóspdes cadastrados com sucesso!";
          
                Console.WriteLine(mensagem);
        } 

        public void CadastrarSuite(Suite novaSuite) => Suite = novaSuite;

        public int QuantidadeHospedes() => _listaHospedes.Count;

        public decimal CalcularDiaria()
        {
            return (_diasReservados < 10) ? Suite.GetValorDiaria() * _diasReservados : (Suite.GetValorDiaria() * _diasReservados) * 0.9M;
        }

        public string ReservaToString() => 
            $"\nDados da reserva\n:" +
            $"#{_idReserva} \t| " +
            $"Quantidade de hóspedes: {QuantidadeHospedes()} \t| " +
            $"Tipo suite: {Suite.GetTipoSuite()} \t| " +
            $"Valor da Diária: R$ {CalcularDiaria()}";

        public void listarHospedes()
        {
            Console.WriteLine("Lista de Hópedes");
            _listaHospedes.ForEach(h => Console.WriteLine(h.HospedeToString()));
        }
    }
}
