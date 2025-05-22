// See https://aka.ms/new-console-template for more information

using NMoneys;
using SimuladorInvestimentos.Core;
using SimuladorInvestimentos.Core.Entity;

var sim =  Simulation.CreateSimulation(Decimal.Parse("500.00") , Decimal.Parse("14"), 11, 0.7, false, 15 );
decimal montanteFinal = new MontanteFinal(sim).Calcular();
var currency = new Money(montanteFinal, CurrencyIsoCode.BRL);
Console.WriteLine("Montante: "  + currency);