using SistemaHospedagem.Models;

List<Pessoa> pessoas = new();

Pessoa p1 = new("Mateus", "Henrique");
Pessoa p2 = new("Henrique", "Alves");
Pessoa p3 = new("Alves", "Souza");

pessoas.Add(p1);
pessoas.Add(p2);
pessoas.Add(p3);

// Console.WriteLine("Nome completo: {0} {1}", p1.Nome, p1.Sobrenome);

Suite s1 = new("Master", 3, 789.67M);
Suite s2 = new("Presidencial", 5, 1367.99M);

// Console.WriteLine("Tipo da suíte: {0} \nCapacidade: {1} \nValor da Diária: {2:C}", s1.Tipo, s1.Capacidade, s1.ValorDiaria);

Reserva r1 = new();
r1.CadastrarHospedes(pessoas);
r1.CadastrarSuite(s1);
r1.DiasReservados = 5;

Console.WriteLine("---------------------------------------------");
Console.WriteLine("Reserva");
Console.WriteLine("---------------------------------------------");
Console.WriteLine($"Suite Reservada: {r1.Suite.Tipo}");
Console.WriteLine("Hospedes");

foreach (Pessoa pessoa in r1.Hospedes)
{
    Console.WriteLine(pessoa.Nome);
}

Console.WriteLine($"Total de Hospedes: {r1.ObterQuantidadeHospedes()} \nDias Reservados: {r1.DiasReservados} \nValor Total da Reserva: {r1.CalcularValorDiarias()}");