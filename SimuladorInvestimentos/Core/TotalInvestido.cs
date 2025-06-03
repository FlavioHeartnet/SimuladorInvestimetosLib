using SimuladorInvestimentos.Core.Entity;

namespace SimuladorInvestimentos.Core;

public class TotalInvestido
{
    private decimal _valorTotalInvestido = 0;
    private Simulation _simulation;
    private TotalInvestido(Simulation simulation)
    {
        _simulation = simulation;
    }

    public static TotalInvestido Create(Simulation simulation)
    {
        return new TotalInvestido(simulation);
    }

    public decimal Calcular()
    {
        return _simulation.ValorInicial + (_simulation.PeriodoMeses * _simulation.AporteMensal);
    }
}