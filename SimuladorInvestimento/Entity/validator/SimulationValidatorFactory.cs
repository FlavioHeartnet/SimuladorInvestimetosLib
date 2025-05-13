namespace SimuladorInvestimento.validator;

public class SimulationValidatorFactory
{
    public IValidator<Simulation> Create()
    {
        return new SimulationValidator();
    }
}