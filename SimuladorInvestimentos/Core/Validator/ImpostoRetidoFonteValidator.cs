using SimuladorInvestimentos.Core.Entity.validator;

namespace SimuladorInvestimentos.Core.Validator;

public class ImpostoRetidoFonteValidator: IValidator<ImpostoRendaRetido>
{
    public void Validate(ImpostoRendaRetido entity)
    {
        if (entity.GetAliquota() < 0)
        {
            throw new ArgumentException("Aliquota não deve ser negativo");
        }

        if (entity.GetMontanteFinal() < 0)
        {
            throw new ArgumentException("Montante não deve ser negativo");
        }
    }
}