using SimuladorInvestimentos.Core.Entity;
using SimuladorInvestimentos.Core.Validator;

namespace SimuladorInvestimentos.Core;

public class RendimentoEmJuros
{
    private decimal _montanteFinal;
    private Simulation _simulador;
    private RendimentoEmJuros(decimal montanteFinal, Simulation sim)
    {
        _montanteFinal = montanteFinal;
        _simulador = sim;
        Validate();
    }

    private void Validate()
    {
        new RendimentoEmJurosFactory().Create().Validate(this);
    }

    public decimal GetMontanteFinal()
    {
        return _montanteFinal;
    }

    public int GetPeriodoMeses()
    {
        return _simulador.PeriodoMeses;
    }

    public static RendimentoEmJuros Create(decimal montanteFinal, Simulation sim)
    {
        return new RendimentoEmJuros(montanteFinal, sim);
    }

    public decimal Calcular()
    {
        return _montanteFinal - ((_simulador.ValorInicial + _simulador.AporteMensal) * _simulador.PeriodoMeses);
    }
    
    
}