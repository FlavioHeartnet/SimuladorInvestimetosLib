// See https://aka.ms/new-console-template for more information

using NMoneys;
using SimuladorInvestimentos.Core;
using SimuladorInvestimentos.Core.Entity;
using SimuladorInvestimentos.Core.Utils;

var sim =  Simulation.CreateSimulation(Decimal.Parse("500,05") , Decimal.Parse("14"), Decimal.Parse("500"), 0.7, false, 15 );
var aliquota = new AliquotaIr().Calcular(sim.PediodoAnos);
decimal montanteFinal = new MontanteFinal(sim).Calcular();
decimal rendimentoMensal = RendimentoMensal.Create(montanteFinal, sim).Calcular();
decimal rendimentoEmJuros = RendimentoEmJuros.Create(montanteFinal, sim).Calcular();
decimal montanteDepoisIr = MontanteDepoisIr.Create(montanteFinal, aliquota).Calcular();
decimal impostoRetidoFonte = ImpostoRendaRetido.Create(montanteFinal, aliquota).Calcular();

var montanteCurrency = new MoneyFormat().Format(montanteFinal);
var rendimentoMensalCurrency = new MoneyFormat().Format(rendimentoMensal);
var rendimentoEmJurosCurrency = new MoneyFormat().Format(rendimentoEmJuros);
var montanteDepoisCurrency = new MoneyFormat().Format(montanteDepoisIr);
var impostoRetidoFonteCurrency = new MoneyFormat().Format(impostoRetidoFonte);
var aliquotaFormated =  aliquota * 100 + "%";

Console.WriteLine("Montante: "  + montanteCurrency);
Console.WriteLine("Rendimento Mensal: "  + rendimentoMensalCurrency);
Console.WriteLine("Rendimento apenas de Juros: "+ rendimentoEmJurosCurrency);
Console.WriteLine("Montante depois do IR: "+ montanteDepoisCurrency + " Aliquota: "+  aliquotaFormated);
Console.WriteLine("Valor de Imposto Retido: "+ impostoRetidoFonteCurrency);