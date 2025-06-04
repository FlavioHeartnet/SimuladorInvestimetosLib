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

        if (entity.GetTotalInvestido() < 0)
        {
            throw new ArgumentException("Total investido não deve ser negativo");
        }
    }
}