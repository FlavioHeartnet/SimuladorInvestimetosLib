using SimuladorInvestimentos.Core.Entity.validator;

namespace SimuladorInvestimentos.Core.Validator;

public class RendimentoEmJurosFactory 
{
    public IValidator<RendimentoEmJuros> Create()
    {
        return new RendimentoemJurosValidator();
    }
}