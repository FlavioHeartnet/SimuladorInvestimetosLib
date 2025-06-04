using SimuladorInvestimentos.Core.Entity;

namespace SimuladorInvestimentos.Core;

public class MontanteFinal
{
    private Simulation _simulation;
    private MontanteFinal(Simulation simulation)
    {
        _simulation = simulation;
    }

    public static MontanteFinal Create(Simulation simulation)
    {
        return new MontanteFinal(simulation);
    }

    public decimal Calcular()
    {
        var pwrTax = TaxPow();
        var montante =  (_simulation.ValorInicial * pwrTax)  + (_simulation.AporteMensal * ((pwrTax-1)/_simulation.TaxaJurosMensal));
        if (_simulation.TaxaCustodia > 0)
        {
            var feeTaxMontly = _simulation.TaxaCustodia / 12 / 100;
            return montante * Decimal.Parse(Math.Pow(1 - feeTaxMontly, _simulation.PeriodoMeses).ToString());
        }
        return montante;
        
    }

    private decimal TaxPow()
    {
        decimal pwrTax = Decimal.Parse(Math
            .Pow(1 + Double.Parse(_simulation.TaxaJurosMensal.ToString()), _simulation.PeriodoMeses)
            .ToString()); // Aqui é feito a conversão para double devido a restriçao do Math.pow não aceitar decimal, esta linha representa (1+r)elevado a n
        return pwrTax;
    }
}