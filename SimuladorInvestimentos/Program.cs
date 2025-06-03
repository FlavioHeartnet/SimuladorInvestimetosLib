// See https://aka.ms/new-console-template for more information

using NMoneys;
using SimuladorInvestimentos.Core;
using SimuladorInvestimentos.Core.Entity;
using SimuladorInvestimentos.Core.Utils;

var sim =  Simulation.CreateSimulation(Decimal.Parse("500,05") , Decimal.Parse("14"), Decimal.Parse("500"), 0.7, false, 15 );
decimal montanteFinal = new MontanteFinal(sim).Calcular();
decimal rendimentoMensal = RendimentoMensal.Create(montanteFinal, sim).Calcular();
decimal rendimentoEmJuros = RendimentoEmJuros.Create(montanteFinal, sim).Calcular();

var montanteCurrency = new MoneyFormat().Format(montanteFinal);
var rendimentoMensalCurrency = new MoneyFormat().Format(rendimentoMensal);
var rendimentoEmJurosCurrency = new MoneyFormat().Format(rendimentoEmJuros);

Console.WriteLine("Montante: "  + montanteCurrency);
Console.WriteLine("Rendimento Mensal: "  + rendimentoMensalCurrency);
Console.WriteLine("Rendimento apenas de Juros: "+ rendimentoEmJurosCurrency);