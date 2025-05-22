using SimuladorInvestimentos.Core.Entity;

namespace SimuladorInvestimentos.Core;

public class MontanteFinal
{
    private Simulation _simulation;
    public MontanteFinal(Simulation simulation)
    {
        _simulation = simulation;
    }

    public decimal Calcular()
    {
        var pwrTax = TaxPow();
        return _simulation.ValorInicial * pwrTax  + _simulation.AporteMensal * ((pwrTax-1)/_simulation.TaxaJurosMensal);
    }

    private decimal TaxPow()
    {
        decimal pwrTax = Decimal.Parse(Math
            .Pow(1 + Double.Parse(_simulation.TaxaJurosMensal.ToString()), _simulation.PeriodoMeses)
            .ToString()); // Aqui é feito a conversão para double devido a restriçao do Math.pow não aceitar decimal, esta linha representa (1+r)elevado a n
        return pwrTax;
    }
}