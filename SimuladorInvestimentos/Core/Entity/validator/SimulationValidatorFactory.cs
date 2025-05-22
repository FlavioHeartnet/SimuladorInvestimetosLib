namespace SimuladorInvestimentos.Core.Entity.validator;

public class SimulationValidatorFactory
{
    public IValidator<Simulation> Create()
    {
        return new SimulationValidator();
    }
}