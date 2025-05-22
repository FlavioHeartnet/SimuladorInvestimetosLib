namespace SimuladorInvestimentos.Core.Entity.validator;

public class SimulationValidator: IValidator<Simulation>
{
    public void Validate(Simulation entity)
    {
        if (entity.AporteMensal < 0)
        {
            throw new ArgumentException("Aporte Mensal não deve ser negativo");
        }

        if (entity.ValorInicial < 0)
        {
            throw new ArgumentException("Valor não deve ser negativo");
        }

        if (entity.TaxaCustodia < 0)
        {
            throw new ArgumentException("Taxa de Custodia não deve ser negativo");
        }

        if (entity.TaxaJurosAnual < 0)
        {
            throw new ArgumentException("Taxa de Juros anual deve ser maior que 0");    
        }

    }
}