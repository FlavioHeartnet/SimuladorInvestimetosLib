using SimuladorInvestimentos.Core.Entity.validator;

namespace SimuladorInvestimentos.Core.Validator;

public class ImpostoRetidoFonteFactory
{
    public IValidator<ImpostoRendaRetido> Create()
    {
        return new ImpostoRetidoFonteValidator();
    }
}