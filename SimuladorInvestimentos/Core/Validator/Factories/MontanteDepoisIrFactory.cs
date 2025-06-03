using SimuladorInvestimentos.Core.Entity.validator;

namespace SimuladorInvestimentos.Core.Validator;

public class MontanteDepoisIrFactory
{
    public IValidator<MontanteDepoisIr> Create()
    {
        return new MontanteDepoisIrValidator();
    }
}