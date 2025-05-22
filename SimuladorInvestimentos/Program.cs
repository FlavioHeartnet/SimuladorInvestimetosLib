// See https://aka.ms/new-console-template for more information

using SimuladorInvestimentos.Core;
using SimuladorInvestimentos.Core.Entity;

var sim =  Simulation.CreateSimulation(Decimal.Parse("500.00") , Decimal.Parse("14"), 11, 0.7, false, 15 );
decimal MontanteFinal = new MontanteFinal(sim).Calcular();
Console.WriteLine("Montante: "  + MontanteFinal);