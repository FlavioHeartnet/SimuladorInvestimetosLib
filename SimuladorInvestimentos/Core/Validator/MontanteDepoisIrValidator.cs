using SimuladorInvestimentos.Core.Entity.validator;

namespace SimuladorInvestimentos.Core.Validator;

public class MontanteDepoisIrValidator: IValidator<MontanteDepoisIr>
{
    public void Validate(MontanteDepoisIr entity)
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