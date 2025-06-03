using SimuladorInvestimentos.Core.Entity;

namespace SimuladorInvestimentos.Core;

public class RendimentoMensal
{
    private Simulation _simulation;
    private decimal _montanteFinal;
    private RendimentoMensal(Simulation simulation, decimal montanteFinal)
    {
        _simulation = simulation;
        _montanteFinal = montanteFinal;
    }

    public static RendimentoMensal Create(decimal montante, Simulation simulation)
    {
        return new RendimentoMensal(simulation, montante);
    }

    public decimal Calcular()
    {
        return (_montanteFinal * _simulation.TaxaJurosAnual) / 100 / 12;
    }
}