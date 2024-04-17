using SistemaDeHospedagem.Models;

Reserva r1 = new Reserva(1, 10);
Suite s1 = new Suite(1, "luxo", 4, 160.00M);
Hospede h1 = new Hospede(1, "João", "Veiga");

List<Hospede> hospedes = new List<Hospede>();

hospedes.Add(h1);

r1.CadastrarSuite(s1);
r1.CadastrarHospede(hospedes);

Console.WriteLine(r1.ReservaToString());
r1.listarHospedes();

Reserva r2 = new Reserva(2, 9);
Suite s2 = new Suite(2, "Simples", 1, 160.00M);
Hospede h2 = new Hospede(2, "Kleby", "Barros");

hospedes.Add(h2);

r2.CadastrarSuite(s2);
r2.CadastrarHospede(hospedes);

Console.WriteLine(r2.ReservaToString());
r2.listarHospedes();