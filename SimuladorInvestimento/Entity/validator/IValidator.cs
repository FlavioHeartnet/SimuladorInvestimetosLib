namespace SimuladorInvestimento.validator;

public interface IValidator<T>
{
    void Validate(T entity);
}