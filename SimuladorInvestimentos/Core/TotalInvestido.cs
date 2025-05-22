using SimuladorInvestimentos.Core.Entity;

namespace SimuladorInvestimentos.Core;

public class TotalInvestido
{
    private decimal _valorTotalInvestido = 0;
    private Simulation _simulation;
    public TotalInvestido(Simulation simulation)
    {
        _simulation = simulation;
    }

    public decimal Calcular()
    {
        decimal taxaJurosMensal = _simulation.TaxaJurosAnual / 100;
        for (int i = 0; i < taxaJurosMensal; i++)
        {
            _valorTotalInvestido += _simulation.AporteMensal;
        }
        
        return _valorTotalInvestido + _simulation.ValorInicial;
    }
}