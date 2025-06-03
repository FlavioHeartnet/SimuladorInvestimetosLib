using SimuladorInvestimentos.Core.Entity.validator;

namespace SimuladorInvestimentos.Core.Validator;

public class RendimentoemJurosValidator: IValidator<RendimentoEmJuros>
{
    public void Validate(RendimentoEmJuros entity)
    {
        if (entity.GetMontanteFinal() < 0)
        {
            throw new ArgumentException("Montante não deve ser negativo");
        }
        
        if (entity.GetPeriodoMeses() < 0)
        {
            throw new ArgumentException("Periodo em Meses não deve ser negativo");
        }
        
        
    }
}