using SimuladorInvestimentos.Core.Entity;
using SimuladorInvestimentos.Core.Validator;

namespace SimuladorInvestimentos.Core;

public class RendimentoEmJuros
{
    private decimal _montanteFinal;
    private decimal _totalInvestido;
    private RendimentoEmJuros(decimal montanteFinal, decimal sim)
    {
        _montanteFinal = montanteFinal;
        _totalInvestido = sim;
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

    public decimal GetTotalInvestido()
    {
        return _totalInvestido;
    }

    public static RendimentoEmJuros Create(decimal montanteFinal, decimal sim)
    {
        return new RendimentoEmJuros(montanteFinal, sim);
    }

    public decimal Calcular()
    {
        return _montanteFinal - _totalInvestido;
    }
    
    
}